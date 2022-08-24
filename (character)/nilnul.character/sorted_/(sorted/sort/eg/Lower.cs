using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	public class Lower
	{
		static public string Genereate() {
			var r = new StringBuilder();
			for (char	i = 'a'; i <= 'z'; i++)
			{
				r.Append(i);

			}

			return r.ToString();
		}
	}
}
