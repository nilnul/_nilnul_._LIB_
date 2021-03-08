using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.str.be
{
	public class Disjoint<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		static public bool Eval(IEnumerable<Set_eqDefault<T,TEq>> sets) {
			if (sets.Count()==0)
			{
				return true;
			}
			else
			{
				return Eval(sets.First(), sets.Skip(1));
			}
		}

		static public bool Eval(Set_eqDefault<T,TEq> set, IEnumerable<Set_eqDefault<T,TEq>> sets) {
			return sets.All( a=>nilnul.set.co._DisjointX.Disjoint(set, a));

		}

	}
}
