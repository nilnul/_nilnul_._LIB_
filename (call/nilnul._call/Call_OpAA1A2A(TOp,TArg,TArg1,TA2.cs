using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract partial class Call_OpArgArg1Arg2A<TOp,TArg,TArg1,TArg2>
		:Call_ArgArg1Arg2A<TArg,TArg1,TArg2>
	{
		private TOp	 _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}
		public Call_OpArgArg1Arg2A(TOp op,TArg arg,TArg1 arg1,TArg2 arg2)
			:base(arg,arg1,arg2)
		{
			this.op = op;

		}
		
		
		
	}
}
