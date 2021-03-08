using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.function.binary
{
	public partial class Expr<TArg1,TArg2,TResult>
		:ExprI<TResult>
	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		private TArg2 _arg2;

		public TArg2 arg2
		{
			get { return _arg2; }
			set { _arg2 = value; }
		}

		private Func<TArg1,TArg2,TResult> _func;

		public Func<TArg1,TArg2,TResult> func
		{
			get { return _func; }
			set { _func = value; }
		}


		public Expr(TArg1 arg1,TArg2 arg2,Func<TArg1,TArg2,TResult> func)
		{
			this.arg1 = arg1;
			this.arg2 = arg2;
			this.func = func;
		}





		public TResult eval()
		{
			return func(arg1,arg2);
		}
	}
}
