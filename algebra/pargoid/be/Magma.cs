using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.algebra.pargoid.be
{
	public class Magma
	{
		static public bool Eval<T,TEq>(Set<T,TEq> set, Func<T,T> func )
			where TEq :IEqualityComparer<T>
		{

			///if each duo of elements in set are processed by the func, resulting no exception but an element inside the set.
			/// 
			throw new NotImplementedException();
		}
	}
}
