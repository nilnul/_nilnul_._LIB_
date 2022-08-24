using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.enumable.be_
{
	static public class _NoneX
	{

		public static bool None<TSource>(
			this nilnul.str_.EnumableI<TSource> source
			,
			Func<TSource, bool> predicate
		)
		{
			return nilnul.seq.be_._NoneX.None(source, predicate);
		}

		public static bool None<TSource>(
			this IEnumerable<TSource> source
		)
		{
			return nilnul.seq.be_._NoneX.None(source);
		}


	}
}
