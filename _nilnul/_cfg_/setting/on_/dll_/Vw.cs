using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul._cfg_.setting.on_.dll_
{
	static public class _VwX
	{
		static public string Vw(System.Configuration.Configuration config, string sectionName, string settingName)
		{
			//System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			// Retrieve the userSettings gorup


			ConfigurationSectionGroup group = config.SectionGroups[@"userSettings"];
			if (group == null) return null;

			// Get the program settings
			ClientSettingsSection clientSection = group.Sections[sectionName] as ClientSettingsSection;
			if (clientSection == null) return null;

			// This retrieves the value associated with the key
			string sFileName = clientSection.Settings.Get(settingName).Value.ValueXml.InnerText;

			return sFileName;

			//// Check if ab123 has a value and the file exists
			//if (!string.IsNullOrEmpty(sFileName) && System.IO.File.Exists(sFileName))
			//{
			//	using (StreamReader sr = new StreamReader(sFileName))
			//	{
			//		string line;
			//		// Read and display lines from the file until the end of  
			//		// the file is reached. 
			//		while ((line = sr.ReadLine()) != null)
			//		{
			//			System.Diagnostics.Debug.WriteLine(line);
			//		}
			//	}
			//}

		}
	}
}
