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
	/// <typeparam name="P"></typeparam>
	/// a morphism from A to R. So A is put first.
	public partial class UnaFuncCall<P, R>
		: ExprI<R>
		,
		UnaOpCallI<R>
	{

		public Func<P, R> op;

		public P arg;





		public UnaFuncCall(P arg, Func<P, R> op)
		{
			this.op = op;
			this.arg = arg;

		}

		public override string ToString()
		{

			return op.ToString() + "(" + arg.ToString() + ")";
		}



	}
}
