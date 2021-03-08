using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.function.binary
{
	public class Function<TArg1,TArg2,TResult>
		:FunctionI<TArg1,TArg2>
	{
		private Func<TArg1,TArg2,TResult> _func;

		public Func<TArg1,TArg2,TResult> func
		{
			get { return _func; }
			set { _func = value; }
		}
		

		public Function(Func<TArg1,TArg2,TResult> func)
		{
			this.func = func;
		}
					
	}
}
