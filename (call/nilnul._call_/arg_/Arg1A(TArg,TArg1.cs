using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call_.arg_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	public abstract partial class Arg1A<TArg,TArg1>
		:ArgA<TArg>
	{
		private TArg1 _arg1;
		public TArg1 arg1
		{
			get
			{
				return _arg1;
			}
			set
			{
				_arg1=value;
			}
		}
		
		public Arg1A(TArg arg,TArg1 arg1)
			:base(arg)
		{
			this.arg1 = arg1;

		}
	}
}
