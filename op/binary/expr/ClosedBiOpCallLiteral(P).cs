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
	public partial class ClosedBiOpCallLiteral<P>
		:
		BiOpCallA<LiteralExprI<P>,LiteralExprI<P>,ClosedBiOpI<P>>
		,
		LiteralExprI<P>
		
		
		
	{
		

		public ClosedBiOpCallLiteral(LiteralExprI<P> a1, LiteralExprI<P> a2, ClosedBiOpI<P> op ):
			base(a1,a2,op)
		{
			
		}
					

	}
}
