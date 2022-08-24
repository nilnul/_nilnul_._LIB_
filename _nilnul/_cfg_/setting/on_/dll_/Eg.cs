using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._nilnul._cfg_.setting.on_.dll_
{
	class Eg
	{
		internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
		{
			//Parses a config file and loads its settings
			public void Load(string filename)
			{
				System.Xml.Linq.XElement xml = null;
				try
				{
					string text = System.IO.File.ReadAllText(filename);
					xml = System.Xml.Linq.XElement.Parse(text);
				}
				catch
				{
					//Pokemon catch statement (gotta catch 'em all)

					//If some exception occurs while loading the file,
					//assume either the file was unable to be read or
					//the config file is not in the right format.
					//The xml variable will be null and none of the
					//settings will be loaded.
				}

				if (xml != null)
				{
					foreach (System.Xml.Linq.XElement currentElement in xml.Elements())
					{
						switch (currentElement.Name.LocalName)
						{
							case "userSettings":
							case "applicationSettings":
								foreach (System.Xml.Linq.XElement settingNamespace in currentElement.Elements())
								{
									if (settingNamespace.Name.LocalName == "SnipetTester.Properties.Settings")
									{
										foreach (System.Xml.Linq.XElement setting in settingNamespace.Elements())
										{
											LoadSetting(setting);
										}
									}
								}
								break;
							default:
								break;
						}
					}
				}
			}

			//Loads a setting based on it's xml representation in the config file
			private void LoadSetting(System.Xml.Linq.XElement setting)
			{
				string name = null, type = null, value = null;

				if (setting.Name.LocalName == "setting")
				{
					System.Xml.Linq.XAttribute xName = setting.Attribute("name");
					if (xName != null)
					{
						name = xName.Value;
					}

					System.Xml.Linq.XAttribute xSerialize = setting.Attribute("serializeAs");
					if (xSerialize != null)
					{
						type = xSerialize.Value;
					}

					System.Xml.Linq.XElement xValue = setting.Element("value");
					if (xValue != null)
					{
						value = xValue.Value;
					}
				}


				if (string.IsNullOrEmpty(name) == false &&
					string.IsNullOrEmpty(type) == false &&
					string.IsNullOrEmpty(value) == false)
				{
					switch (name)
					{
						//One of the pitfalls is that everytime you add a new
						//setting to the config file, you will need to add another
						//case to the switch statement.
						case "SettingSomething":
							this[name] = value;
							break;
						default:
							break;
					}
				}
			}
		}
	}
}
