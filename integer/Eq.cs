using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.integer
{
	public class Eq : IEqualityComparer<int>
	{
		public bool Equals(int x, int y)
		{
			return x == y;
			throw new NotImplementedException();
		}

		public int GetHashCode(int obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
