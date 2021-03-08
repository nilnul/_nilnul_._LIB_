using nilnul.function;
using System;
using System.Net;

namespace nilnul.op.binary.expr
{
	/// <summary>
	/// Given two literal expressions, return a literal expression.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="P2"></typeparam>
	public partial class BiOpCallLiteral<A1,A2,P1,P2,Op,R>
		:BiOpCallA<A1,A2,BiOpI<P1,P2,R>>,LiteralExprI<R>

		where A1:LiteralExprI<P1>

		where A2:LiteralExprI<P2>
		where Op:BiOpI<P1,P2,R>
		
		
	{
		

		public BiOpCallLiteral(A1 a1,A2 a2,Op op ):
			base(a1,a2,op)
		{
			
		}
					

	}
}
