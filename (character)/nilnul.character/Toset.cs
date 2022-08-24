using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character
{
	public class Toset:SortedSet<char>
	{
		public Toset()
		{

		}
		public Toset(params char[] chars):base(chars)
		{

		}

		public Toset(string s):base(s)
		{

		}

	}
}
