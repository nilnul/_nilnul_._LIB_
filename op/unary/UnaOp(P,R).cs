using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class UnaOp<P,R>
		:UnaOpI<P,R>
	{
		Func<P, R> op;


		public UnaOp(Func<P,R> op)
		{
			this.op = op;
		}


		public R eval(P a)
		{
			throw new NotImplementedException();
		}
	}
}
