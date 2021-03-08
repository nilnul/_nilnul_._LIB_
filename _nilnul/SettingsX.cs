using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul
{
	static public class SettingsX
	{
		/// <summary>
		/// an example for how to get a value from settings or caller functions.
		/// </summary>
		/// <param name="userAdjustedInUi">specified by caller function; a in - memory value</param>
		/// <returns></returns>
		static public int ProcLife(int? userAdjustedInUi=null) {
			return userAdjustedInUi
				??
				Settings1.Default?.procLife
				??
				(int)Settings1.Default.Properties[nameof(Settings1.Default.procLife)].DefaultValue
			;
		}
	}
}
