using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt.be;
using Name1 = nilnul.txt.be.Name.Asserted;

namespace nilnul.name
{
	public class Eq : IEqualityComparer<Name1>
	{
		public bool Equals(Name1 x, Name1 y)
		{
			return x.val == y.val;
			throw new NotImplementedException();
		}

		public int GetHashCode(Name1 obj)
		{
			return obj.val.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
