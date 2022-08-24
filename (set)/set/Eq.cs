using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public class Eq1<T, TEq> : IEqualityComparer<Set1<T, TEq>>
		where TEq : IEqualityComparer<T>, new()
	{
		public bool Equals(Set1<T, TEq> x, Set1<T, TEq> y)
		{
			return x.IsSubsetOf(y) && y.IsSubsetOf(x);
			throw new NotImplementedException();
		}

		public int GetHashCode(Set1<T, TEq> obj)
		{
			return 0;

			//throw new NotImplementedException();
		}


		static public Eq1<T,TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq1<T,TEq>>.Instance;
			}
		}

	}
}
