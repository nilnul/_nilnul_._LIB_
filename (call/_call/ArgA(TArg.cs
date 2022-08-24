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
	public abstract partial class ArgA<TArg>
	{
		private TArg _arg;
		public TArg arg
		{
			get
			{
				return _arg;
			}
			set
			{
				_arg=value;
			}
		}
		public ArgA(TArg arg)
		{
			this.arg = arg;
		}
	}
}
