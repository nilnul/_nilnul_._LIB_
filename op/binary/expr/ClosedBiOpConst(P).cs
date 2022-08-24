using System;
using System.Net;

namespace nilnul
{
	/// <summary>
	/// Given two literal expressions, return a literal expression.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="P2"></typeparam>
	public partial class ClosedBiOpConst<P>
		:
		BiOpCallA<ConstI<P>,ConstI<P>,ClosedBiOpI<P>>
		,
		ConstI<P>
		
		
		
	{
		

		public ClosedBiOpConst(ConstI<P> a1, ConstI<P> a2, ClosedBiOpI<P> op ):
			base(a1,a2,op)
		{
			
		}


		public ClosedBiOpConst(ConstI<P> a1, ConstI<P> a2, Func<P,P,P> op) :
			base(a1, a2, new ClosedBiOp<P>( op))
		{

		}


		public P eval()
		{
			return this.op.func(arg1.eval(),arg2.eval()) ;
		}

		public override string ToString()
		{
			return op.ToString()+string.Format("({0},{1})",arg1,arg2);
		}
	}
}
