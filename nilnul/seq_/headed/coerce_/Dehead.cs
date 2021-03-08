using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Seq<testc> = System.Collections.Generic.IEnumerable<testc>;

namespace nilnul.seq_.headed.coerce_
{
	static public class _DeheadX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_headed"></param>
		/// <returns></returns>
		/// <exception cref="">may throw no head exception</exception>
		static public IEnumerable<T> _Seq<T>(IEnumerable<T> _headed) {
			return _headed.Skip(1);
		}
	}
}
