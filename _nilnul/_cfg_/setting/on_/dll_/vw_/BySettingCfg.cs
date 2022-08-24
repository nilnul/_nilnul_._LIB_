using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;


namespace _nilnul._cfg_.setting.on_.dll_.vw_
{

	static public class _SettingOnCfgX
	{


		static public ClientSettingsSection Section(ApplicationSettingsBase appSettings, Configuration config)
		{

			string appSettingsXmlName =
nilnul.Properties.Settings.Default.Context["GroupName"].ToString();
			// returns "MyApplication.Properties.Settings";

			// Open settings file as XML

			return config.GetSectionGroup("userSettings")
				.Sections[appSettingsXmlName]
				as ClientSettingsSection;
			//.SectionInformation;
		}



		static public string Txt(ClientSettingsSection section, string settingName)
		{
			return section.Settings.Get(settingName).Value.ValueXml.InnerText;
		}

		static public string Txt(ApplicationSettingsBase appSettings, Configuration config, string settingName)
		{
			return Txt(Section(appSettings, config), settingName);
		}


		static public string TxtOnGeneric<T>(T appSettings, string settingName)
			where T : ApplicationSettingsBase
		{
			return Txt(
				appSettings,
				_nilnul.cfg.on_._DllX.Cfg(typeof(T).Assembly)
				, settingName
			);

		}

		static public string Txt(ApplicationSettingsBase appSettings, string settingName)
		{
			return Txt(
				appSettings,
				_nilnul.cfg.on_._DllX.Cfg(appSettings.GetType().Assembly)
				, settingName
			);

		}



		//	internal static void Import(Configuration config, string settingsFilePath)
		//	{
		//		if (!File.Exists(settingsFilePath))
		//		{
		//			throw new FileNotFoundException();
		//		}

		//		var appSettings = nilnul.Properties.Settings.Default;

		//		try
		//		{
		//			//var config =ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

		//			string appSettingsXmlName =
		//nilnul.Properties.Settings.Default.Context["GroupName"].ToString();
		//			// returns "MyApplication.Properties.Settings";

		//			// Open settings file as XML
		//			var import = XDocument.Load(settingsFilePath);
		//			// Get the whole XML inside the settings node
		//			var settings = import.XPathSelectElements("//" + appSettingsXmlName);

		//			config.GetSectionGroup("userSettings")
		//				.Sections[appSettingsXmlName]
		//				.SectionInformation
		//				.SetRawXml(settings.Single().ToString());
		//			config.Save(ConfigurationSaveMode.Modified);
		//			ConfigurationManager.RefreshSection("userSettings");

		//			appSettings.Reload();
		//		}
		//		catch (Exception) // Should make this more specific
		//		{
		//			// Could not import settings.
		//			appSettings.Reload(); // from last set saved, not defaults
		//		}
		//	}

		//internal static void Export(string settingsFilePath)
		//	{
		//		nilnul.Properties.Settings.Default.Save();
		//		var config =
		//ConfigurationManager.OpenExeConfiguration(
		//ConfigurationUserLevel.PerUserRoamingAndLocal);
		//		config.SaveAs(settingsFilePath);
		//	}
		//}

	}
}