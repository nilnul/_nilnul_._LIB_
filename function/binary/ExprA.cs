using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.function.binary
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg1"></typeparam>
	/// <typeparam name="TArg2"></typeparam>
	/// <typeparam name="TPara1"></typeparam>
	/// <typeparam name="TPara2"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <remarks>
	/// it's abstract because TArg1 must be subtype of TPara1, or the exprI(vari) 
	/// </remarks>
	public abstract partial class ExprA<TArg1, TArg2, TPara1,TPara2,TResult>

		
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

		private Func<TPara1,TPara2,TResult> _func;

		public Func<TPara1,TPara2,TResult>  func
		{
			get { return _func; }
			set { _func = value; }
		}





		public ExprA(TArg1 arg1, TArg2 arg2, Func<TPara1,TPara2,TResult>  func)
		{
			this.arg1 = arg1;
			this.arg2 = arg2;
			this.func = func;

		}


		
					

		
					






	}
}
