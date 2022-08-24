using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.be_.any.vow
{
	public class En<T, TEq>
		: nilnul.set.vow.En<T, TEq, Vow<T, TEq>>
		where TEq:IEqualityComparer<T>,new()
	{
		public En(Set1<T, TEq> val) : base(val)
		{
		}
	}
}
