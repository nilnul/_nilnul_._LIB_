using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.cfg.linq_
{
	static public class _DefaultX
	{
		public const string NAME = "default";
		static public string OnAppCfg()
		{
			return System.Configuration.ConfigurationManager.ConnectionStrings[NAME].ConnectionString;
		}

		static public string OnLibCfg(Assembly assembly=null) {
			// The dllPath can't just use Assembly.GetExecutingAssembly().Location as ASP.NET doesn't copy the config to shadow copy path

			var dllPath = new Uri((assembly??Assembly.GetExecutingAssembly()).GetName().CodeBase).LocalPath;

			var dllConfig = ConfigurationManager.OpenExeConfiguration(dllPath);

			return dllConfig.ConnectionStrings.ConnectionStrings[NAME ].ConnectionString;
		}

	}

}
