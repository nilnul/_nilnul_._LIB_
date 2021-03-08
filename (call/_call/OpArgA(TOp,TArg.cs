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
	public abstract partial class OpArgA<TOp,TArg>
		:OpA<TOp>
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}
		
		
		public OpArgA(TOp op,TArg arg)
			:base(op)
		{
			this.arg = arg;
			
		}
	}
}
