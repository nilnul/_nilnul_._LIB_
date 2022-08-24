using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.str
{
	public class VarName_LedByPqrst:List<string>
	{
		public const string COMMON_VAR_NAMES_LOWERCASE_PQRST_LED = "pqrstxyzuvwabcdefghijkmn";  //exclude l, o


		public VarName_LedByPqrst()
		{
			foreach (var item in COMMON_VAR_NAMES_LOWERCASE_PQRST_LED)
			{
				this.Add(item.ToString());
			}
		}



	}
}
