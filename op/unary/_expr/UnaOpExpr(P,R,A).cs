using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.op
{
	public partial class UnaOpExpr<P,R, A>
		:
		UnaOpCallA<A,UnaOpI<P,R>>

		where A:ExprI<P>

	{

		
		public UnaOpExpr( UnaOpI<P,R> op,A operand)
			:base(operand,op)
		{
			
			

		}






	}
}
