using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	public class Latin
	{
		static public string Genereate() {
			return Upper.Genereate() + Lower.Genereate();
		}
	}
}
