using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.str
{
	static public class ContainX
	{
		static public bool Contain(this IEnumerable<Var1> str, Var1 x) {
			return str.Contains(x, var.Eq.Instance);
		}

		static public bool Contain(this IEnumerable<VarI1> str, VarI1 x) {
			return str.Contains(x, var.Eq_ofVarI.Instance);
		}


	}
}
