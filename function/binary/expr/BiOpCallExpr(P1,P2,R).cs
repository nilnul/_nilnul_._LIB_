using System;
using System.Net;

namespace nilnul.op
{
	/// <summary>
	/// Given two literal expressions, return a literal expression.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="P2"></typeparam>
	public partial class BiOpCallExpr<P1,P2,R>
		:BiOpCallA<ExprI<P1>,ExprI<P2>,BiOpI<P1,P2,R>>
		,
		ExprI<R>

		
		
		
	{
		

		public BiOpCallExpr(ExprI<P1> a1,ExprI<P2> a2,BiOpI<P1,P2,R> op ):
			base(a1,a2,op)
		{
			
		}
					

	}
}
