using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.cfg.inDllOfDll_0
{
	/* 
Yes, you can and should put the common configuration settings in the config file for your DLL. Just add an app.config file to the DLL project, and make sure you read the configuration settings from inside the DLL. When deployed, your config file needs to have the name "MyDLL.dll.config" (assuming your DLL is named "MyDLL.dll") and be in the same folder as the DLL.

share
improve this answer
answered Oct 2 '08 at 11:59 

MusiGenesis 
61.3k35166309 
9
Whats if it's in the GAC? – Ryu Apr 22 '09 at 20:39 

how will the dll refer to the config file? How will it know the config file's location? – BKSpurgeon Mar 24 '16 at 5:23 

@BKSpurgeon: it doesn't know that the config file is in the same folder as the DLL - that's just the first place that it looks for it. That's why you don't have to specify the path of the config file anywhere inside the DLL. – MusiGenesis Mar 24 '16 at 19:46  

@MusiGenesis "That's why you don't have to specify the path of the config file anywhere inside the DLL." --> do you mean to say: that's why you don't have to specify the path of the config file anywhere inside the folder which contains the dll? – BKSpurgeon Mar 24 '16 at 23:55 
	 *//*
	  You can have separate configuration file, but you'll have to read it "manually", the ConfigurationManager.AppSettings["key"] will read only the config of the running assembly.
		 */
	static public class _AgnosticX
	{
		
		

	}

}
