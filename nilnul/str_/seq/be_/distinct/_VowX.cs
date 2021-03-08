using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.be_.distinct
{
	static public class _VowX
	{

		static public void Vow<T,TEq>(this IEnumerable<T> vars,TEq eq)
			where TEq :IEqualityComparer<T>

		{

			nilnul.vow_.True.Vow(_DistinctX.Be(vars,eq));

		}

		static public void Vow<T,TEq>(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()

		{

			Vow(vars, nilnul.Singleton1<TEq>.Instance);

		}


	}
}
