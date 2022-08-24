using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	public abstract partial class Call_ArgArg1Arg2A<TArg,TArg1,TArg2>
		:Call_ArgArg1A<TArg,TArg1>
	{
		private TArg2 _arg2;
		public TArg2 arg2
		{
			get
			{
				return _arg2;
			}
			set
			{
				_arg2=value;
			}
		}
		
		public Call_ArgArg1Arg2A(TArg arg,TArg1 arg1,TArg2 arg2)
			:base(arg,arg1)
		{
			this.arg2 = arg2;

		}
	}
}
