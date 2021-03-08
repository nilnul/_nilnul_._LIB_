using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	static public class ObjectToConsoleX
	{
		static public void ToConsoleLine(this object o) {
			Console.WriteLine(o);
		}
	}
}
