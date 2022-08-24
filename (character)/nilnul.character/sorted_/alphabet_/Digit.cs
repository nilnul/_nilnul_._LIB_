using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sorted_.alphabet_
{
	public class Digit:sort.be.Alphabet.Asserted
		
	{
		static public readonly Digit Singleton = SingletonByDefault<Digit>.Instance;

		public Digit():base("0123456789")
		{
		}

		public SortedSet<char> sortedSet {
			get {
				return val;
			}
		}

		
	}
}
