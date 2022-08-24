using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character
{
	public class Sort:SortedSet<char>
	{
		public Sort()
		{

		}
		public Sort(params char[] chars):base(chars)
		{

		}

		public Sort(string s):base(s)
		{

		}

	}
}
