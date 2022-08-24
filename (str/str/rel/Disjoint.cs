using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.str.rel
{

	static public class _DisjointX
	{
		
		[Obsolete("optimized")]
		static public bool Disjoint_onJoint<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> eq)
		{
			return !_JointX.Joint(a,b, eq);

		}




		static public bool Disjoint_usingIntersect<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> eq)
		{
			return a.Intersect(b, eq).Count() == 0;

		}

		static public bool Disjoint<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> eq)
		{
			return Disjoint_usingIntersect(a,b, eq);

		}


		static public bool Disjoint<T,TEq>(IEnumerable<T> a, IEnumerable<T> b)
			where TEq:IEqualityComparer<T>,new()
		{
			return Disjoint_usingIntersect(a,b,SingletonByDefault<TEq>.Instance);

		}




	}
}
