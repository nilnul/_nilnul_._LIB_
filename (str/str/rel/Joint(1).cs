using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.str.rel
{
	static public class _JointX
	{
		



		static public bool Joint<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> eq)
		{
			return a.Intersect(b, eq).Count() > 0;

		}

		static public bool Joint<T,TEq>(IEnumerable<T> a, IEnumerable<T> b)
			where TEq:IEqualityComparer<T>,new()
		{
			return Joint(a,b,SingletonByDefault<TEq>.Instance);

		}




	}
}
