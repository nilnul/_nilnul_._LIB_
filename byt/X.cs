using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.byt
{
	static public class X
	{
		static public string ToTxt(this byte x) {
			return Convert.ToString(x, 2).PadLeft(8, '0');
		}

		static public string ToBase16txt(this byte x) {
			return Convert.ToString(x, 16).PadLeft(2, '0');
		}

		static public string ToBase10txt(this byte x) {
			return Convert.ToString(x, 10);
		}

		static public string ToHex(this byte x) {
			return x.ToString("X");	
		}



	}
}
