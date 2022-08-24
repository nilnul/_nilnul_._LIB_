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
	public partial class BiOpCallExpr<A1,A2,P1,P2,Op,R>
		:BiOpCallA<A1,A2,BiOpI<P1,P2,R>>,ExprI<R>

		where A1:ExprI<P1>

		where A2:ExprI<P2>
		where Op:BiOpI<P1,P2,R>
		
		
	{
		

		public BiOpCallExpr(A1 a1,A2 a2,Op op ):
			base(a1,a2,op)
		{
			
		}



		public R eval()
		{
			throw new NotImplementedException();
		}
	}
}
