using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	static public class NotContainX
	{
		static public bool NotContain<T,TEq>(this IEnumerable<T> str, T x, TEq eq)
			where TEq:IEqualityComparer<T>
		{
			return !str.Contain(x,eq);
		}

		static public bool NotContain<T,TEq>(this StrI1<T> str, T x, TEq eq)
			where TEq:IEqualityComparer<T>
		{
			return !str.Contain(x,eq);
		}


		static public bool NotContain_eqDefault<T,TEq>(this StrI1<T> str, T x)
			where TEq:IEqualityComparer<T>,new()
		{
			return !str.Contain_eqDefault<T,TEq>(x);
		}




		static public bool NotContain_eqDefault<T,TEq>(this IEnumerable<T> str, T x)
			where TEq:IEqualityComparer<T>,new()
		{
			return NotContainX.NotContain<T,TEq>(str,x,SingletonByDefault<TEq>.Instance);
		}


	}
}
