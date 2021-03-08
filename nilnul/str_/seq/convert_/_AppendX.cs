using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.convert_
{
	static public class _AppendX
	{
		static public IEnumerable<T> Seq<T>(IEnumerable<T> seq,T tip) {
			return seq.Concat(new[] { tip});
		}

		static public SeqI<T> Str<T>(IEnumerable<T> seq, T tip) {
			return new Seq<T>(Seq(seq,tip));
		}

		static public SeqI<T> Str<T>(SeqI<T> seq, T tip) {
			return Str(seq,tip);
		}

	}
}
