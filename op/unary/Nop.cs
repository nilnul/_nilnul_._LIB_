using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.unary
{
	static public partial class NopX
	{
		static public T Nop<T>(T x) {
			return x;
		}
		
	}
}
