using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.cfg.ov_.dll_
{
	public class ByDenote
	{
		public static void MethodName(string denote)
		{
			var config = ConfigurationManager.OpenExeConfiguration( denote /*"foo.dll"*/);
			//config.ConnectionStrings. [etc]

		}
	}
}
