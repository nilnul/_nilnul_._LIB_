using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/*Basically, App.config is an “older” mechanism to define and read simple key/value combinations. MySettings is a newer version of this mechanism which allows you to do the same, but also allows the developer to define and update objects and their properties. Also using a nifty interface, during designtime. 

MySettings(.settings) allow you to create and access values that are persisted between application execution sessions. Think in terms like: user preferences, (data) connection strings, control properties etc.

Handy note for Settings: the User scope is read/write during runtime, whilst the Application scope of a setting is read-only during runtime.

		If you are referring to the "Properties.Settings.Default", this is completely different from the app.config file. They are stored in two completely different places.

 One downside of using the Properties.Settings.Default is that the file is specific for the assembly version. So if you change your assembly version, then it uses a different file and you lose any settings that were saved for the previous assembly version. Though there are ways to get around this. 
*/
	class Cfg
	{
	}
}
