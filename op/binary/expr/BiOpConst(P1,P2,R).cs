using System;
using System.Net;
using nilnul.op;

namespace nilnul
{
	/// <summary>
	/// Given two literal expressions, return a literal expression.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="P2"></typeparam>
	public partial class BiOpConst<P1,P2,R>
		:
		BiOpCallA2<ConstI<P1>,ConstI<P2>,BiOpI<P1,P2,R>>
		,
		ConstI<R>

		
		
		
	{
		

		public BiOpConst(ConstI<P1> a1,ConstI<P2> a2,BiOpI<P1,P2,R> op ):
			base(a1,a2,op)
		{
			
		}



		public R eval()
		{
			return op.func(arg1.eval(),arg2.eval());
		}
	}
}
