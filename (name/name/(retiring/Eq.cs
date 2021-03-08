using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt.be;
using Name1 = nilnul.obj.Name ;

namespace nilnul.var.name
{
	[Obsolete()]
	public class Eq : IEqualityComparer<Name1>
	{
		public bool Equals(Name1 x, Name1 y)
		{
			return x.avowed == y.avowed;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Name1 obj)
		{
			return obj.avowed.GetHashCode();
			//throw new NotImplementedException();
		}
	}
}
