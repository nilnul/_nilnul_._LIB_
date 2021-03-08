using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul.op
{
	public partial class ClosedBiOp<T>
		:ClosedBiOpI<T>
	{

		public Func<T, T,T> func
		{
			get;
			set;
		}
		public ClosedBiOp(Func<T,T,T> func)
		{
			this.func = func;
		}

		public override string ToString()
		{
			return func.ToString();
		}
	}
}
