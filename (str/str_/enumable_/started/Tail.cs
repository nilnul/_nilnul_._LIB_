using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.enumable_.started
{
	static public class _TailX
	{
		static public IEnumerable<T> Tail<T>(this IEnumerable<T> seed) {
			return seed.Skip(1);
		}
	}
}
