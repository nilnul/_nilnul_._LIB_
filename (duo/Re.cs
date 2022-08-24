using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{



	public partial interface ReI<T,T1>
	{
		bool be(T obj,T1 obj1);
	}


	public partial interface ReI<T> : ReI<T, T> { }


}
