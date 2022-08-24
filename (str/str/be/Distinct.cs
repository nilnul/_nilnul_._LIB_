using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.be
{
	static public class DistinctX
	{

		static public bool IsDistinct<T, TEq>(this StrI1<T> str, TEq eq)
			where TEq:IEqualityComparer<T>

		{
			if (str is str.SansI)
			{
				return true;
			}
			var seeded = (str as str.SeededI_forGeneric<T>);

			return seeded.tail.IsDistinct(eq) && seeded.tail.Contain(seeded.seed, eq);

		}


		static public bool IsDistinct_eqDefault<T, TEq>(this StrI1<T> str)
			where TEq:IEqualityComparer<T>,new()

		{
			return IsDistinct(str, SingletonByDefault<TEq>.Instance);

		}



		static public bool IsDistinct<T,TEq>
		
			(this IEnumerable<T> vars, TEq eq)
			where TEq :IEqualityComparer<T>


		{
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return IsDistinct(skipped,eq) && skipped.NotContain<T,TEq>(vars.First(),eq);
			}


		}

		static public bool IsDistinct<T,TEq>
		
			(this List<T> vars, TEq eq)
			where TEq :IEqualityComparer<T>


		{
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return IsDistinct(skipped,eq) && skipped.NotContain<T,TEq>(vars.First(),eq);
			}


		}


		static public bool IsDistinct_eqDefault<T,TEq>
		
			(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()


		{
			return DistinctX.IsDistinct<T, TEq>(vars, SingletonByDefault<TEq>.Instance);


		}

		static public bool IsDistinct<T, TEq>(params  T[] str)
				where TEq :IEqualityComparer<T>,new()
		
		{
			return DistinctX.IsDistinct_eqDefault<T,TEq>(str as IEnumerable<T>);
		}


		static public bool IsDistinct_eqDefault<T,TEq>
		
			(this List<T> vars)
			where TEq :IEqualityComparer<T>,new()


		{
			return DistinctX.IsDistinct<T, TEq>(vars, SingletonByDefault<TEq>.Instance);


		}



		static public void AssertDistinct<T,TEq>(this IEnumerable<T> vars,TEq eq)
			where TEq :IEqualityComparer<T>

		{

			nilnul.Assert1.True(IsDistinct(vars,eq));

		}

		static public void AssertDistinct_eqDefault<T,TEq>(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()

		{

			AssertDistinct(vars, SingletonByDefault<TEq>.Instance);

		}


	}
}
