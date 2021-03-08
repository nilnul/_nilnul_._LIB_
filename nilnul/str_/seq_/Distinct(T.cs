using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq_
{
	public class Distinct<T> : seq.be_.distinct.vow.En<T>
	{
		public Distinct(SeqI<T> val, IEqualityComparer<T> elEq) : base(val, elEq)
		{
		}
	}
}
