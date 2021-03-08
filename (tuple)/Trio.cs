using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public class Trio<T>:Tuple<T,T,T>
	{

		public Trio(T a, T b,T c):base(a, b,c)
		{

		}
	}


}
