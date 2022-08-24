using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul._cfg_
{
	/*
Why two mechanisms and not just one?

They serve different purposes. The settings API offers read/write access from the application, whereas config is read only (unless you write the file in code).

Settings can be defined per user or per application, and are designed to be volatile. User settings are written to hidden folder within User Profile storage which is permitted under UAC.

App.config is per application only. Changes to App.config aren't automatically picked up. It requires restart or code to refresh the values. Under UAC users are not permitted to write to the application directories such as Program Files, so this file should be considered static readonly.


What are the most common scenarios for using app.config over Settings.settings, and vice versa?

You could use Settings in a desktop application for storing user preferences, or settings that change at runtime. 

You would use App.config for more generic static settings, like connection strings etc, or for defining the configuration of components used within your app.


What happens if my app is using Settings.settings and I change a value in app.config after it's been deployed?

If the application is redeployed then it will pick up the new settings, unless there are user/app customisations on the machine already in which case it will continue to use those, unless you wipe them. 

If you add new settings, these will get picked up. In fact the default values are baked into the Settings class, so even if the app.config is empty the Settings still function.


		C:\Documents and Settings\[username]\Local Settings\Application Data\[AssemblyCompanyName]\[NameOfProject].[SomeLongUniqueString]\[AssemblyVersion]\user.config

 that's in XP. 

		The difference is that the .settings stuff [which was added in .NET 2.0 / VS2005] layers a strongly typed class on top of a set of settings that belong together whereas Configuration.AppSettings just lets you retrieve strings, forcing you to do any conversions, and doesnt have the notion of defaults. (the Configuration class has actually been shunted into a side assembly to reflect this - you need to add a reference to System.Configuration explicitly if you want it).

		You can do things like ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.PerUserRoamingAndLocal ).FilePath

		// Map the roaming configuration file. This
  // enables the application to access 
  // the configuration file using the
  // System.Configuration.Configuration class
  ExeConfigurationFileMap configFileMap =
    new ExeConfigurationFileMap();
  configFileMap.ExeConfigFilename = 
    roamingConfig.FilePath;

  // Get the mapped configuration file.
  Configuration config =
    ConfigurationManager.OpenMappedExeConfiguration(
      configFileMap, ConfigurationUserLevel.None);

		You can also define a <userSettings> block within app.exe.config to provide default values for user-scoped settings. 

		and user.config will reside in the location specified by the Application.LocalUserAppDataPath property

		LocalFileSettingsProvider persists settings to configuration files that have the extension .config. The contents of configuration files are structured as XML documents. Depending on whether the setting is scoped at either the application-level or user-level, the configuration data is stored as elements within an <applicationSettings> or a <userSettings> section group, respectively. Each of these section groups is represented by a corresponding AppSettingsSection or ClientSettingsSection, respectively. Each section object is owned and administered by a configuration section handler, which is an object of type IConfigurationSectionHandler. 

		Application-scoped settings and the default user-scoped settings are stored in a file named application.exe.config, which is created in the same directory as the executable file. Application configuration settings are read-only. Specific user data is stored in a file named user.config, stored under the user's home directory. If roaming profiles are enabled, two versions of the user configuration file could exist. In such a case, the entries in the roaming version take precedence over duplicated entries in the local user configuration file. 

*/
	class Setting
	{
	}
}
