using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.be
{
	public class White
	{
		static public bool Eval(char c) {
			return c== ' ' || c== '\t' || c== '\r' || c== '\n';
		}

		static public bool Eval(char? c) {
			return c== ' ' || c== '\t' || c== '\r' || c== '\n';
		}

	}
}
