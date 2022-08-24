using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.be
{
	public class Alphabet:nilnul.BeI<Sort>
	{
		static public bool Eval(Sort x) {
			return x.Count > 1;
		}

		public bool be(Sort obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.be.Asserted<Sort,Alphabet>
		{
			public Asserted(Sort x):base(x)
			{

			}

			public Asserted(params char[] chars):this(new Sort(chars))
			{

			}

			public Asserted(string s):this(new Sort(s)) {

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
