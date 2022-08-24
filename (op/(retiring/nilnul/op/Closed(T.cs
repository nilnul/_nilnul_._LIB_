using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public partial class Closed<T>
		:
		nilnul.Op<T,T>
		,
		
		ClosedI<T>
	{
		
		public Closed(Func<T,T> func)
			:base(func)
		{

		}



	}
}
