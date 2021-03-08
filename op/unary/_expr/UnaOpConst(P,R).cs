using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul
{

	/// <summary>
	/// arguments with an op, possibly a composite op.
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="P"></typeparam>
	/// a morphism from A to R. So A is put first.
	public partial class UnaOpConst<P, R>
		:UnaOpCallA<ConstI<P>,UnaOpI<P,R>>
		,
		
		ConstI<R>
		
	{

		


		public UnaOpConst(ConstI<P> arg, UnaOpI<P, R> op)
			:base(arg,op)
		{
			
		}



		public UnaOpConst(ConstI<P> arg, Func<P, R> op)
			: this(arg, new UnaOp<P, R>(op))
		{

		}

		public R eval() {

			return op.func(this.arg.eval());

			
		}


		

		public override string ToString()
		{
			
			return op.ToString()+"("+this.arg.ToString()+")";
		}



	}
}
