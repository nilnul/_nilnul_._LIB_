using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.set.co
{
	static public partial class _DisjointX
		
	{

		static public bool Disjoint<T,TEq>(this Set_eqDefault<T,TEq> a, Set_eqDefault<T,TEq> b)
			where TEq:IEqualityComparer<T>,new()
		{

			return nilnul.str.rel._DisjointX.Disjoint<T,TEq>(a, b);

		}
		
		
					
	}
}
