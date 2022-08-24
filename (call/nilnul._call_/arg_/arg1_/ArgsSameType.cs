using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call_.arg_.arg1_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	public abstract  class ArgsSameType<TArg>
		:Arg1A<TArg,TArg>
	{
		
		
		public ArgsSameType(TArg arg,TArg arg1)
			:base(arg,arg1)
		{

		}
	}
}
