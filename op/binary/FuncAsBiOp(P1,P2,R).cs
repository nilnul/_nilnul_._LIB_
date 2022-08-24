using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public partial class BiOp<P1,P2,R>
		:BiOpI<P1,P2,R>
	{

		public Func<P1, P2, R> func
		{
			get;
			set;
		}
		public BiOp(Func<P1,P2,R> func)
		{
			this.func = func;
		}
	}
}
