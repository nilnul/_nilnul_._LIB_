using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	public class Digit
	{
		static public readonly string Generated = Generate();

		static public string Generate() {
			var r = new StringBuilder();
			for (char	i = '0'; i <= '9'; i++)
			{
				r.Append(i);

			}

			return r.ToString();
		}
	}
}
