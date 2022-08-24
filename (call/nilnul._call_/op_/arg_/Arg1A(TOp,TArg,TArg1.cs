using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call_.op_.arg_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract  class Arg1A<TOp,TArg,TArg1>
		:ArgA<TOp,TArg>
	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public Arg1A(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg)
		{
			this.arg1 = arg1;

		}
		
		
		
	}
}
