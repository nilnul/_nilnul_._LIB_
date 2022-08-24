using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul._cfg_
{
	/*AppSettings values are also limited to a single AppSettings section inside of an application's or Web config file. Luckily you can also create custom configuration sections use the same configuration format in custom sections in a config file as long as those custom sections get declared:
<configuration>
  <configSections>
    <section name="CustomConfiguration" requirePermission="false" 
             type="System.Configuration.NameValueSectionHandler,System,Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
  configSections>
  <CustomConfiguration>
    <add key="ApplicationName" value="Configuration Tests" />
    <add key="DebugMode" value="Default" />
    <add key="MaxDisplayListItems" value="15" />
    <add key="SendAdminEmailConfirmations" value="False" />
    <add key="MailServer" value="=" />
    <add key="MailServerPassword" value="==" />
  CustomConfiguration>
configuration>

You can then access a custom section with:
var settings = ConfigurationManager.GetSection("CustomConfiguration") as NameValueCollection;            
Console.WriteLine(settings["ApplicationName"]);

and essentially get the same behavior as you get with the AppSettings keys. The collection you get back is a read-only NameValueCollection that's easy to run through and read from.

.NET's configuration provider also supports strongly typed configuration sections via code, which involves creating classes based base on the ConfigurationSection class. This gives you a slightly different configuration format that's a little less verbose than the add/key/value structure of NameValue type configuration:
xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section name="MyCustomConfiguration" requirePermission="false"
             type="Westwind.Utilities.Configuration.MyCustomConfigurationSection,Westwind.Utilities.Configuration.Tests"/>
  configSections>
  <MyCustomConfiguration 
        ApplicationName="Configuration Tests"  
        MaxDisplayItems="25"
        DebugMode ="ApplicationErrorMessage"         
        />
configuration>

This is a little more involved in that you need to define a class and define each property along with some inherited logic to retrieve the configuration value. 
class MyCustomConfigurationSection : ConfigurationSection
{        
    [ConfigurationProperty("ApplicationName")]
    public string ApplicationName
    {
        get { return (string) this["ApplicationName"]; }
        set { this["ApplicationName"] = value; }
    }

    [ConfigurationProperty("MaxDisplayItems",DefaultValue=15)]
    public int MaxDisplayItems
    {
        get { return (int) this["MaxDisplayItems"]; }
        set { this["MaxDisplayItems"] = value; }
    }

    [ConfigurationProperty("DebugMode")]
    public DebugModes DebugMode
    {
        get { return (DebugModes) this["DebugMode"]; }
        set { this["DebugMode"] = value; }
    }                
}

but the advantage is that you can reference the class as a strongly typed class in your application. With a bit of work you can even get Intellisense to work on your configuration settings inside of the configuration file. You can find out more from this detailed article from Rob Seeder. Strongly typed configuration classes are useful for static components that have lots of configuration settings, but for typical dynamic configuration settings that frequently change in applications the more dynamic section of key value pairs is more flexible and easier to work with dynamically.
*/
	class Section
	{
	}
}
