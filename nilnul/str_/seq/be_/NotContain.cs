using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.be_
{
	static public class _NotContainX
	{
		static public bool NotContain<T>(IEnumerable<T> str, T element, IEqualityComparer<T> eq) {
			return !str.Contains(element,eq);
		}
	}
}
