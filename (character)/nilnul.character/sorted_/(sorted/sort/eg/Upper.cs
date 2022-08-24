using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	public class Upper
	{
		static public string Genereate() {
			var r = new StringBuilder();
			for (char	i = 'A'; i <= 'Z'; i++)
			{
				r.Append(i);

			}

			return r.ToString();
		}
	}
}
