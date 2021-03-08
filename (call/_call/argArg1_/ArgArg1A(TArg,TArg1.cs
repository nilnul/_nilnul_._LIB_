using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call.argArg1_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	public abstract partial class Closed<TArg>
		: ArgArg1A<TArg, TArg>
	{
		public Closed(TArg arg, TArg arg1) : base(arg, arg1)
		{
		}
	}
}
