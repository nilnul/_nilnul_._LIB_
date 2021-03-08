using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.op
{

	/// <summary>
	/// arguments with an op, possibly a composite op.
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	/// a morphism from A to R. So A is put first.
	public partial class UnaOpCall<A,P,R>
		:ExprI<A>

		where A:ValI<P>	//the literal, or the var.
	{

		UnaOpI<P, R> op;

		A arg;


		public UnaOpCall(A arg, UnaOpI<P,R> op)
		{
			this.op = op;
			this.arg = arg;
		}

		public UnaOpCall(A arg,Func<P,R> func)
			:this(arg,new UnaOp<P,R>(func))
		{
			
		}

	

	}
}
