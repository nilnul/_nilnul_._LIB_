using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{
	[Obsolete()]
	public class Eq : IEqualityComparer<Var1>
	{
		static public readonly Eq Instance = new Eq();

		public bool Equals(Var1 x, Var1 y)
		{
			return object.ReferenceEquals(x, y);

			throw new NotImplementedException();
		}

		public int GetHashCode(Var1 obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
	[Obsolete()]
	public class Eq_ofVarI : IEqualityComparer<VarI1>
	{
		static public readonly Eq_ofVarI Instance = new Eq_ofVarI();

		public bool Equals(VarI1 x, VarI1 y)
		{
			return object.ReferenceEquals(x, y);

			throw new NotImplementedException();
		}

		public int GetHashCode(VarI1 obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}


}
