using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.be
{
	public class En<T, TBe>
		: nilnul.vow.En<T, nilnul.be.Vow<T, TBe>>
		where TBe : nilnul.BeI<T>, new()
	{
		public En(T val) : base(val)
		{
		}
	}
}
