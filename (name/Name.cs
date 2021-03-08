using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{

	public class Name
		: nilnul.be.En<string, nilnul.var._name.txt.Be>

	{

		public Name(string name) : base(name)
		{

		}

		static public bool operator ==(Name x, Name y)
		{
			return x.en == y.en;
		}
		static public bool operator !=(Name x, Name y)
		{
			return !(x == y);
		}
		static public implicit operator string(Name name)
		{
			return name.en;
		}

		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}


			return this == obj;
			// TODO: write your implementation of Equals() here
			//throw new NotImplementedException();
			//return base.Equals(obj);
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{

			return en.GetHashCode();
			// TODO: write your implementation of GetHashCode() here
			//throw new NotImplementedException();
			//return base.GetHashCode();
		}

	}
}

