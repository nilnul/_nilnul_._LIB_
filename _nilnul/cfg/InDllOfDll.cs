using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace _nilnul.cfg
{
	/*I had the same problem and searched the web for several hours but I couldn't find any solution so I made my own. I wondered why the .net configuration system is so inflexible.
Background: I want to have my DAL.dll to have its own config file for database and DAL settings. I also need the app.config for Enterprise Library and its own configurations. So I need both the app.config and dll.config.
What I did not wanted to do is pass-through every property/setting from the app to my DAL layer!
to bend the "AppDomain.CurrentDomain.SetupInformation.ConfigurationFile" is not possible because I need it for the normal app.config behavior.
My requirements/point of views were:
NO manual copy of anything from ClassLibrary1.dll.config to WindowsFormsApplication1.exe.config because this is unreproducible for other developers.
retain the usage of strong typing "Properties.Settings.Default.NameOfValue" (Settings behavior) because I think this is a major feature and I didn't want to lose it
I found out the lack of ApplicationSettingsBase to inject your own/custom config file or management (all necessary fields are private in these classes)
the usage of "configSource" file redirection is not possible because we would have to copy/rewrite the ClassLibrary1.dll.config and provide several XML files for several sections (I also didn't like this)
I didn't like to write my own SettingsProvider for this simple task as MSDN suggests because I thought that simply would be too much
I only need sections applicationSettings and connectionStrings from the config file
I came up with modifying the Settings.cs file and implemented a method that opens the ClassLibrary1.dll.config and reads the section information in a private field. After that, I've overriden "this[string propertyName]" so the generated Settings.Desginer.cs calls into my new Property instead of the base class. There the setting is read out of the List. 
Finally there is the following code:
You just will have to copy your ClassLibrary1.dll.config from the ClassLibrary1 output directory to your application's output directory. Perhaps someone will find it useful. */
	internal sealed  class Settings 
		: global::System.Configuration.ApplicationSettingsBase
	{
		private List<ConfigurationElement> list;

		/// <summary>
		/// Initializes a new instance of the <see cref="Settings"/> class.
		/// </summary>
		public Settings()
		{
			this.OpenAndStoreConfiguration();
		}

		/// <summary>
		/// Opens the dll.config file and reads its sections into a private List of ConfigurationElement.
		/// </summary>
		private void OpenAndStoreConfiguration()
		{
			string codebase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
			Uri p = new Uri(codebase);
			string localPath = p.LocalPath;
			string executingFilename = System.IO.Path.GetFileNameWithoutExtension(localPath);
			string sectionGroupName = "applicationSettings";
			string sectionName = executingFilename + ".Properties.Settings";
			string configName = localPath + ".config";
			ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
			fileMap.ExeConfigFilename = configName;
			Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

			// read section of properties
			var sectionGroup = config.GetSectionGroup(sectionGroupName);
			var settingsSection = (ClientSettingsSection)sectionGroup.Sections[sectionName];
			list = settingsSection.Settings.OfType<ConfigurationElement>().ToList();

			// read section of Connectionstrings
			var sections = config.Sections.OfType<ConfigurationSection>();
			var connSection = (from section in sections
							   where section.GetType() == typeof(ConnectionStringsSection)
							   select section).FirstOrDefault() as ConnectionStringsSection;
			if (connSection != null)
			{
				list.AddRange(connSection.ConnectionStrings.Cast<ConfigurationElement>());
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="System.Object"/> with the specified property name.
		/// </summary>
		/// <value></value>
		public override object this[string propertyName]
		{
			get
			{
				var result = (from item in list
							  where Convert.ToString(item.ElementInformation.Properties["name"].Value) == propertyName
							  select item).FirstOrDefault();
				if (result != null)
				{
					if (result.ElementInformation.Type == typeof(ConnectionStringSettings))
					{
						return result.ElementInformation.Properties["connectionString"].Value;
					}
					else if (result.ElementInformation.Type == typeof(SettingElement))
					{
						return result.ElementInformation.Properties["value"].Value;
					}
				}
				return null;
			}
			// ignore
			set => base[propertyName] = value;
		}
	}
}
