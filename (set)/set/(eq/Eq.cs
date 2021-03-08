using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	[Obsolete("nilnul.obj")]
	public class Eq<T, TEq> : IEqualityComparer<Set_eqDefault<T, TEq>>
		where TEq : IEqualityComparer<T>, new()
	{
		public bool Equals(Set_eqDefault<T, TEq> x, Set_eqDefault<T, TEq> y)
		{
			return x.IsSubsetOf(y) && y.IsSubsetOf(x);
			throw new NotImplementedException();
		}

		public int GetHashCode(Set_eqDefault<T, TEq> obj)
		{
			return 0;

			throw new NotImplementedException();
		}
	}
}
