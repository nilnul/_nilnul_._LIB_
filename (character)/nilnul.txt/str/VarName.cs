using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.str
{
	public class VarName:List<string>
	{
		public const string COMMON_VAR_NAMES_LOWERCASE = "xyzuvwabcdefghijkmnpqrst";    //exclude l, o


		public VarName()
		{
			foreach (var item in COMMON_VAR_NAMES_LOWERCASE)
			{
				Add(item.ToString());
			}
		}



	}
}
