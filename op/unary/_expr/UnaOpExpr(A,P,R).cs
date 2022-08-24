using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul
{
	public partial class UnaOpExpr<A,P,R>
		:
		UnaOpCallA<A,UnaOpI<P,R>>

		where A:ConstI<P>

	{

		
		public UnaOpExpr( UnaOpI<P,R> op,A operand)
			:base(operand,op)
		{
			
			

		}






	}
}
