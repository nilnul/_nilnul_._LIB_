using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.name
{
	public class Eq1 : IEqualityComparer<Name>
	{
		static public readonly Eq1 Instance=new Eq1();
		public bool Equals(Name x, Name y)
		{
			return x.en == y.en ;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Name obj)
		{
			return obj.en.GetHashCode();

			//throw new NotImplementedException();
		}
	}
}
