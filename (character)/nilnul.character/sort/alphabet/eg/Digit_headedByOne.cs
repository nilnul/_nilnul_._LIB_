using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	public class Digit_headedByOne:sort.be.Alphabet.Asserted
	{
		static public readonly Digit_headedByOne Singleton = SingletonByDefault<Digit_headedByOne>.Instance;
		public Digit_headedByOne():base("1234567890")
		{
		}
	}
}
