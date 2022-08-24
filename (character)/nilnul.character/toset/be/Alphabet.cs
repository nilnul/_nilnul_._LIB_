using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.toset.be
{
	public class Alphabet:nilnul.BeI<Toset>
	{
		static public bool Eval(Toset x) {
			return x.Count > 1;
		}

		public bool be(Toset obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.be.Asserted<Toset,Alphabet>
		{
			public Asserted(Toset x):base(x)
			{

			}

			public Asserted(params char[] chars):this(new Toset(chars))
			{

			}

			public Asserted(string s):this(new Toset(s)) {

			}

			public char next(char x) {
				if (val.Last()==x)
				{
					return val.First();
				}
				return val.SkipWhile(c => c != x).Skip(1).First();;
			}

			static public Asserted CreateDigits() {
				return new Asserted("0123456789");

			}





		}
	}
}
