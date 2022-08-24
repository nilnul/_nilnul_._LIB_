using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.be_.distinct.vow
{
	public class En<T>
		: nilnul.vow.En<str_.SeqI<T>>
	{
		public En(SeqI<T> val, IEqualityComparer<T> elEq) 
			: 
			base(new Vow<T>(elEq), val)
		{
		}
	}


	public class En<T, TEq>
		: nilnul.vow.En<str_.SeqI<T>, Vow<T, TEq>>
		where TEq : IEqualityComparer<T>, new()
	{
		public En(SeqI<T> val) : base(val)
		{
		}
	}
}
