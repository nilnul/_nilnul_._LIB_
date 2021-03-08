using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.byt.str
{
	static public class ToTxtX
	{
		static public string ToTxt(this byte[] x) {
			return nilnul.str.ToTxtX.ToTxt1(x.Select(a=>a.ToTxt()));
		}

		static public string ToBase16Txt(this byte[] x) {
			return nilnul.str.ToTxtX.ToTxt1(x.Select(a=>a.ToBase16txt()));
		}
		static public string ToBase10Txt(this byte[] x) {
			return nilnul.str.ToTxtX.ToTxt1(x.Select(a=>a.ToBase10txt()));
		}

		static public string ToBase16Txt(this byte[] x,string separator) {
			return nilnul.str.ToTxtX.ToTxt1(x.Select(a=>a.ToBase16txt()),separator);
		}

		static public string ToHex(this byte[] x,string separator) {
			return nilnul.str.ToTxtX.ToTxt1(x.Select(a=>a.ToHex()),separator);
		}

		static public string ToHex_byUtf8(this byte[] x) {
			return System.Text.Encoding.UTF8.GetString(x);
		}


		static public string ToHex_byBitConverter(this byte[] x) {
			return BitConverter.ToString(x);
        }

	}
}
