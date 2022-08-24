using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.vow
{
	public class En<T, TEq, TVow> : nilnul.vow.En<nilnul.Set1<T, TEq>, TVow>
		where TEq : IEqualityComparer<T>, new()
		where TVow : nilnul.set.VowI<T, TEq>,new()
	{
		public En(Set1<T, TEq> val) : base(val)
		{
		}
	}
}
