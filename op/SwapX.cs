using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.function
{
	/// <summary>
	/// swap two variables
	/// </summary>
	static public partial class SwapX
	{
		static public void  Swap(ref object a,ref object b){

			Swap<object>(ref a, ref b);
		
		}

		static public void Swap<T>(ref T a,ref T b) {
			T c = a;
			a = b;
			b = c;
		}

	}
}
