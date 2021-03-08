using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.be
{
	public class Vow<T, TEq, TBe>
		: nilnul.be.Vow<nilnul.Set1<T,TEq>,TBe>
		,
		nilnul.set.VowI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
		where TBe : nilnul.set.BeI<T, TEq>, new()
	{
		
	}
}
