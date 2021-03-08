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
	public partial class UnaFuncCall2<P, R>
		: ExprI<R>
		,
		UnaOpCallI<R>
	{

		public Func<P, R> op;

		public P arg;

		public string name;



		public UnaFuncCall2(P arg, Func<P, R> op,string name)
		{
			this.op = op;
			this.arg = arg;
			
			this.name = name;

		}

		public override string ToString()
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return arg.ToString();
				
			}
			return name + "(" + arg.ToString() + ")";
		}



	}
}
