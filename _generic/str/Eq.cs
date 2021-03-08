using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._generic.str
{
	public class Eq<T> : IEqualityComparer<IEnumerable<T>>
	{

		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{

			return x.SequenceEqual(y);

			throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;

			throw new NotImplementedException();
		}
	}
}
