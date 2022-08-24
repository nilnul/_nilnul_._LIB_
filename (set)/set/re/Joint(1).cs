using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.set.co
{
	static public class _JointX
	{
		


		static public bool Joint<T, TEq>(Set_eqDefault<T, TEq> a, Set_eqDefault<T, TEq> b)
			where TEq : IEqualityComparer<T>, new()
		{
			return  nilnul.str.rel._JointX.Joint<T,TEq>(a, b);

		}



		




	}
}
