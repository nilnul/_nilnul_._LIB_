using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.stream
{
	public class Omega1
	{
		private nilnul.character.sort.be.Alphabet.Asserted _alphabet;
		public nilnul.character.sort.be.Alphabet.Asserted alphabet
		{
			get { return _alphabet; }
			set { _alphabet = value; }
		}

		public Omega1(nilnul.character.sort.be.Alphabet.Asserted alphabet)
		{
			_alphabet = alphabet;
		}

		public string increase(string x) {
			if (x=="")
			{
				return _alphabet.val.First().ToString();
			}
			if (x.First()==_alphabet.val.Last())
			{
				return _alphabet.val.First() + increase(x.Substring(1));
			}
			else
			{
				return _alphabet.next(x.First()) + x.Substring(1);
			}
		}

		public IEnumerable<string> txts(string current)
		{
			yield return current;
			while (true)
			{
				yield return current=increase(current);
			}
		}

		public IEnumerable<string> followedTxt(string current)
		{
			while (true)
			{
				yield return current=increase(current);
			}
		}

		public IEnumerable<string> txts()
		{
			return txts("");
		}
	}
}
