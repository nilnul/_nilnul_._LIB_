using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.cfg.on_
{
	/*I write a lot of reusable components. Most recently, I created an assembly to handle notifications in various projects. For this assembly, I needed various configuration options, such as an SMTP server address. For configuration in .NET projects, we turn to App.config files, and in ASP.NET projects, we have the Web.config. In the case of a DLL however, it isn’t really advised to create/use an App.config file. On Stack Overflow, Chris Ammerman goes into great detail on the topic. But, hey, what if you want to use one anyway?

Attempt #1

Reading an assembly’s configuration file is pretty easy, you can access the AppSettings section by opening the configuration using the Assembly.GetExecutingAssembly().Location like so:

var dllPath = Assembly.GetExecutingAssembly().Location;
var dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);

// Get the appSettings section
var appSettings = (AppSettingsSection) dllConfig.GetSection("appSettings");
return appSettings.Settings;

That’s as easy as it is; or is it? This method works fine if you’re using the DLL in a Windows or console application, but try using it in an ASP.NET/ASP.NET MVC application, and you’ll find that Assembly.GetExecutingAssembly().Location points to something like C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\blah\blah\blah (the ASP.NET shadow copy directory). Navigate to that directory, and you won’t find your config file there. One solution could be to copy the file to the temp directory, but that isn’t going to work in the long term. There has to be a better solution! 

Solution

After searching the web for a while, I came across others with my problem. No solution there (although, I have since added one). Continuing my search, I stumbled upon a question about how to use reflection to get the bin path instead of the ASP.NET temporary directory. An answer there gave me something to go on.

Using our same example from above, we only need to change the dllPath. Here’s the full solution:

// The dllPath can't just use Assembly.GetExecutingAssembly().Location as ASP.NET doesn't copy the config to shadow copy path
var dllPath = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase).LocalPath;
var dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);

// Get the appSettings section
var appSettings = (AppSettingsSection) dllConfig.GetSection("appSettings");
return appSettings.Settings;

You’re probably wondering what’s going on with the new Uri(…) in the revised line of code. Well, the CodeBase method ends up returning a uri file path, like file:///C:/Users/.... We need to get that string to a “Windows friendly” path in order to pass it to ConfigurationManager.OpenExeConfiguration. By using the Uri class, we can obtain the path we are looking for by calling the LocalPath property.

That’s all there is to it. This solution seems to work fine outside of ASP.NET as well, so it’s now my “go to” way to read from a DLL config file.

 */
	/// <summary>
	/// 
	/// </summary>
	static public class _DllX
	{
		static public Configuration Cfg(Assembly assembly=null)
		{
			// The dllPath can't just use Assembly.GetExecutingAssembly().Location as ASP.NET doesn't copy the config to shadow copy path
			var dllPath = new Uri( (assembly??Assembly.GetExecutingAssembly()).GetName().CodeBase).LocalPath;
			var dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);

			//ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = "AppConfig/app.config" };

			//var dllConfig1 = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);


		return dllConfig;
		}


		static public KeyValueConfigurationCollection AppSettings(Assembly assembly = null)
		{
			

			// Get the appSettings section
			var appSettings = (AppSettingsSection)Cfg(assembly).GetSection("appSettings");
			return appSettings.Settings;

		}
	}
}
