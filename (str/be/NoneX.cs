using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.be
{
	static public class NoneX
	{

			public static bool None<TSource>(this IEnumerable<TSource> source,
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
