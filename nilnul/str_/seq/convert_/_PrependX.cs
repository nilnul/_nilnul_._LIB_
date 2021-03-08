using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.convert_
{
	static public class _PrependX
	{
		static public IEnumerable<T> Seq<T>(IEnumerable<T> seq,T head) {
			return (new[] { head}).Concat(seq);
		}

		static public SeqI<T> Str<T>(IEnumerable<T> seq, T head) {
			return new Seq<T>(Seq(seq,head));
		}

		static public SeqI<T> Str<T>(SeqI<T> seq, T head) {
			return Str(seq,head);
		}

	}
}
