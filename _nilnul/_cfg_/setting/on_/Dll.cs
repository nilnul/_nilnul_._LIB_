using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul._cfg_.setting.on_
{
	class Dll
	{

		static public string Read(string key)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			// find section
			ClientSettingsSection configSection = config.SectionGroups[@"userSettings"].Sections["Tool.Properties.Settings"] as ClientSettingsSection;

			var setting = configSection.Settings.Get(key).Value.ValueXml.InnerText;
			return setting;
		}


		static public void SaveUserSettingDefault(string clientSectionName, string settingName, object settingValue)
		{
			System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			// find section group
			ConfigurationSectionGroup group = config.SectionGroups[@"userSettings"];
			if (group == null) return;

			// find client section
			ClientSettingsSection clientSection = group.Sections[clientSectionName] as ClientSettingsSection;
			if (clientSection == null) return;

			// find setting element
			SettingElement settingElement = null;
			foreach (SettingElement s in clientSection.Settings)
			{
				if (s.Name == settingName)
				{
					settingElement = s;
					break;
				}
			}
			if (settingElement == null) return;

			// remove the current value
			clientSection.Settings.Remove(settingElement);

			// change the value
			settingElement.Value.ValueXml.InnerText = settingValue.ToString();

			// add the setting
			clientSection.Settings.Add(settingElement);

			// save changes
			config.Save(ConfigurationSaveMode.Full);
		}
	}
}
