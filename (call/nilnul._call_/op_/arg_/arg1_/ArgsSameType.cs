using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call_.op_.arg_.arg1_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	public abstract  class ArgsSameType<TOp,TArg>
		:Arg1A<TOp,TArg,TArg>
	{
		
		
		public ArgsSameType(TOp op, TArg arg,TArg arg1)
			:base(op, arg,arg1)
		{

		}
	}
}
