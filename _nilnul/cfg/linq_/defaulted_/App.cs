using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.cfg.linq_.defaulted_
{
	/// <summary>
	/// windows app or web app
	/// </summary>
	static public class _AppX
	{
		public const string NAME = "default";

		/// <summary>
		/// when in test proj, the following returns null.
		/// </summary>
		/// <returns></returns>
		static public string OnAppCfg()
		{
			return System.Configuration.ConfigurationManager.ConnectionStrings[NAME] // this returns null when in test. so in test, we can use:   theAboveExpression??otherMethod2FetchConnTxt
				?.ConnectionString;
		}

	

	}

}
