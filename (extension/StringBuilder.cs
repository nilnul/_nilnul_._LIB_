using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	static public class _StringBuilderX
	{
		static public StringBuilder Prepend(this StringBuilder sb, string x) {

			return sb.Insert(0, x);
		}

		static public StringBuilder Prepend(this StringBuilder sb, char x) {

			return sb.Insert(0, x);
		}

		static public char Last(this StringBuilder sb) {

			return sb[sb.Length-1];
		}
		static public char First(this StringBuilder sb) {

			return sb[0];
		}

		static public void RemoveLast(this StringBuilder sb) {

			 sb.Remove(sb.Length-1,1);
		}



	}
}
