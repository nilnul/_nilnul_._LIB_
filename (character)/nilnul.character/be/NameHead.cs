using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.be
{
	/// <summary>
	/// can occur anywhere in a name
	/// </summary>
	public class NameHead
	{
		static public bool Eval(char c) {
			return
								c == '_' ||

				NameTail.Eval(c)
				&& !char.IsNumber(c)	
				;
				

		}
	}
}
