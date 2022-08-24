using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	static public partial class X
	{
		static public char ToChar(this bool obj) {
			return obj ? '1' : '0';
		}

		static public string ToTxt(this bool bit) {
			return bit.ToChar().ToString();
		}

		static public bool Fro(int x) { return ! (x == 0); }
	}
}
