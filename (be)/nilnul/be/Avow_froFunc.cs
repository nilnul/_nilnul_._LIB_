using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{


	public class Avow_froFunc<T>
	:

	AssertI<T>


	{
		Func<T, bool> _func;

		public Avow_froFunc(Func<T, bool> func)

		{
			_func = func;
		}

		public void assert(T obj)
		{
			nilnul.Assert1.True(_func(obj));
		}

	}




}
