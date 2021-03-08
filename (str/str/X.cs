using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public static class X
	{
		static public T MaxBy_recur<T, P>(this IEnumerable<T> str, IComparer<T> comparer)
		{

			if (str.Count() == 0)
			{
				return default(T);
			}
			else
			{
				return nilnul.str_.started.X._MaxBy_recur(str, comparer);
			}
		}

		static public T MaxBy_byAggregate<T>(this IEnumerable<T> str, IComparer<T> comparer)
		{

			return str.Count() == 0 ? default(T) : nilnul.str_.started.X._MaxBy_byAggregate(str,comparer
				);
		}

		static public T MaxBy_byAggregate<T,TTarget>(this IEnumerable<T> str, Func<T,TTarget> convert, IComparer<TTarget> comparer)
		{

			return str.Count() == 0 ? default(T) : nilnul.str_.started.X._MaxBy_byAggregate(str,convert, comparer
				);
		}



	}
}
