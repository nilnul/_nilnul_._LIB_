using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.started
{
	public static class X
	{
		static public T _MaxBy_recur<T>(this IEnumerable<T> str_started, IComparer<T> comparer)
		{
			var start = str_started.First();

			var remaining = str_started.Skip(1);

			if (remaining.Count() == 1)
			{
				var t = _MaxBy_recur<T>(str_started, comparer);

				return comparer.Compare(start, t) >= 0 ? start : t;
			}
			return start;
		}


		static public T _MaxBy_byAggregate<T>(this IEnumerable<T> str_started, IComparer<T> comparer)
		{
			return str_started.Skip(1).Aggregate(
				str_started.First(), 
				(x, y)=>comparer.Compare(x,y) >0?x:y 
			);
		}

		static public T _MinBy_byAggregate<T>(this IEnumerable<T> str_started, IComparer<T> comparer)
		{
			return str_started.Skip(1).Aggregate(
				str_started.First(), 
				(x, y)=>comparer.Compare(x,y) <0?x:y 
			);
		}

		static public T _MaxBy_byAggregate<T,TComparable>(this IEnumerable<T> str_started, 
			Func<T,TComparable> func
			,
			IComparer<TComparable> comparer)
		{
			return str_started.Skip(1).Aggregate(
				str_started.First(), 
				(x, y)=>comparer.Compare( func(x),func(y)) >0?x:y 
			);
		}
		static public string _ToTxt_byLoop<T>(this IEnumerable<T> _started, string seperator)
		{



			var str = _started.First().ToString();

			foreach (var item in _started.Skip(1))
			{
				str += seperator + (item).ToString();

			}
			return str;



		}


	}
}
