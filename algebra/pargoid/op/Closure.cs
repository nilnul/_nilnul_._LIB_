using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.algebra.pargoid.op
{
	public class Closure
	{
		/// <summary>
		/// the closure of a pargoid is the smallest set that's closed, or the intersection of all its super, which is magma
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TEq"></typeparam>
		/// <param name="pargoid"></param>
		/// <returns></returns>
		static public Set<T, TEq> Eval<T,TEq>(Pargoid<T,TEq> pargoid)
			where TEq :IEqualityComparer<T>
		{
			throw new NotImplementedException();
		}
	}
}
