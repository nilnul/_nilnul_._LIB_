using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.be
{
	[Obsolete("txt::")]
	public class Name:nilnul.BeI<string>
	{
		static public bool Eval(string s) {
			return s != "" 
				&& nilnul.character.be.NameHead.Eval(s.First()) 
				&& s.Skip(1).All(c => nilnul.character.be.NameTail.Eval(c));
		}

		public bool be(string obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted
			:nilnul.be.Asserted<string,Name>

		{

			public Asserted(string name):base(name)
			{

			}

			static public bool operator ==(Asserted x, Asserted y) {
				return x.val == y.val;
			}
			static public bool operator !=(Asserted x, Asserted y) {
				return !(x == y);
			}
			static public implicit operator string (Asserted name) {
				return name.val;
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
				throw new NotImplementedException();
				return base.Equals(obj);
			}

			// override object.GetHashCode
			public override int GetHashCode()
			{

				return val.GetHashCode();
				// TODO: write your implementation of GetHashCode() here
				throw new NotImplementedException();
				return base.GetHashCode();
			}

		}
	}
}
