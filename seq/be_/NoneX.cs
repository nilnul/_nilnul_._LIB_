using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.seq.be_
{
	static public class _NoneX
	{

		public static bool None<TSource>(
			this IEnumerable<TSource> source,
										 Func<TSource, bool> predicate)
		{
			return !source.Any(predicate);
		}

		public static bool None<TSource>(this IEnumerable<TSource> source
										)
		{
			return !source.Any();
		}


	}
}
