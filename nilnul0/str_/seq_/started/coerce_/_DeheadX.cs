using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq_.started.coerce_
{

	static public class _DeheadX
	{
		static public IEnumerable<T> _Seq<T>(IEnumerable<T> _started) {
			return _started.Skip(1);
		}
	}
}
