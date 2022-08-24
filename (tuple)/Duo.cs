using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete()]
	public class Duo<T>:Tuple<T,T>
	{

		public Duo(T a, T b):base(a, b)
		{

		}
	}


}
