using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.be_.any
{
	public class Vow<T,TEq>
		:
		nilnul.set.be.Vow<
			T,TEq, Dwelt<T,TEq>
		>
		where TEq:IEqualityComparer<T>,new()
	{
	}
}
