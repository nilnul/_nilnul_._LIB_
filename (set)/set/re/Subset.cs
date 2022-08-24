using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.rel
{

	public partial class Subset<T,TEq>
		

		where TEq:IEqualityComparer<T>,new()
	{

		public bool contain(Set_eqDefault<T,TEq> a, Set_eqDefault<T,TEq> b) {

			return a.IsSubsetOf(b);

		}



		[Obsolete()]
		static public bool Be(Set<T,TEq> a, Set<T,TEq> b) 
		{

			return a.IsSubsetOf(b);
		
		}

		static public bool Be(Set_eqDefault<T,TEq> a, Set_eqDefault<T,TEq> b) 
		{

			return a.IsSubsetOf(b);
		
		}

		static public void Assert(
			
			Set_eqDefault<T,TEq> a,

			Set_eqDefault<T,TEq> b
			
		) {

			nilnul.Assert1.True(Be(a, b));
		}


		[Obsolete()]
		static public void Assert(
			
			Set<T,TEq> a, 
			
			Set<T,TEq> b
			
		) {

			nilnul.Assert1.True(Be(a, b));
		}



		
	}
}

