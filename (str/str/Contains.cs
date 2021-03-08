using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	static public class ContainX
	{
		static public bool Contain<T,TEq>(this IEnumerable<T> str, T x, TEq eq)
			where TEq:IEqualityComparer<T>
		{
			return str.Contains(x, eq);
		}

		static public bool Contain<T,TEq>(this StrI1<T> str, T x, TEq eq)
			where TEq:IEqualityComparer<T>
		{


			if (str is SansI)
			{
				return false;
			}
			var seeded = str as str.SeededI_forGeneric<T>;
			return eq.Equals(seeded.seed, x) || seeded.tail.Contain(x, eq);
		}

		static public bool Contain_eqDefault<T,TEq>(this StrI1<T> str, T x)
			where TEq:IEqualityComparer<T>,new()
		{
			return str.Contain(x, SingletonByDefault<TEq>.Instance);
		}




		static public bool Contain_eqDefault<T,TEq>(this IEnumerable<T> str, T x)
			where TEq:IEqualityComparer<T>,new()
		{
			return str.Contains(x, SingletonByDefault<TEq>.Instance);
		}




	}
}
