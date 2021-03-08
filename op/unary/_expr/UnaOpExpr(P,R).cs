using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul
{
	public partial class UnaOpExpr<P,R>
		:
		UnaOpCallA<ExprI<P>,UnaOpI<P,R>>
		,
		ExprI<R>


	{

		
		public UnaOpExpr( ConstI<P> operand,UnaOpI<P,R> op)
			:base(operand,op)
		{
			
			

		}






	}
}
