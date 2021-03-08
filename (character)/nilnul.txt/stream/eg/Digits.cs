using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.stream.eg
{
	public class Digits 
		:
	nilnul._stream.NextI<string>
	{

		static public readonly Digits Singleton = SingletonByDefault<Digits>.Instance;

		IEnumerator<string> txts= new Omega1(
			nilnul.character.sort.eg.Digit_headedByOne.Singleton
		).txts().GetEnumerator();

		public string next()
		{
			txts.MoveNext();
			return txts.Current;
			throw new NotImplementedException();
		}
	}
}
