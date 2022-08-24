using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.str
{
	static public class NotContainX
	{
		static public bool NotContain(this IEnumerable<Var1> str, Var1 x)
		{
			return !str.Contain(x);
		}

		static public bool NotContain(this IEnumerable<VarI1> str, VarI1 x)
		{
			return !str.Contain(x);
		}


	}
}
