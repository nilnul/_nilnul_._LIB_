using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq_
{
	public class Distinct<T,TEq> : seq.be_.distinct.vow.En<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		public Distinct(SeqI<T> val ) : base(val )
		{
		}
	}
}
