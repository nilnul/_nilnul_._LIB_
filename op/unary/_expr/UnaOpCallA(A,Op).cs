using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public abstract partial class UnaOpCallA<TArg,TOp> 
		
		:OpCallA<TOp>
		///TArg must be TOp.P.OpCallVal, or this expression throws exception.

	{
		public TArg operand
		{
			get;
			set;
		}

		public UnaOpCallA(TArg operand,TOp op )
			:base(op)
		{
			this.operand = operand;

		}


	
	}
}
