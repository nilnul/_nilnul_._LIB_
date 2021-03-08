using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.function.unary
{
	public partial class Expr<TArg,TResult>
		:ExprI<TResult>
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		private Func<TArg,TResult> _func;

		public Func<TArg,TResult> func
		{
			get { return _func; }
			set { _func = value; }
		}
		
		

		public Expr(Func<TArg,TResult> func, TArg arg)
		{
			this.func = func;
			this.arg = arg;
			
		}


		public TResult eval()
		{
			return func(arg);
		}
	}
}
