using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class EqX
	{
		static public bool Eq<T>(T a,T b, Func<T,T,bool> EqNoNull) {
			if (a==null)
			{
				if (b==null)
				{
					return true;
					
				}
				return false;
				
			}
			return EqNoNull(a, b);

		
		}
	}
}
