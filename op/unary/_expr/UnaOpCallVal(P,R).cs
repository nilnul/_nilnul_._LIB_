using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.op
{

	/// <summary>
	/// This is the function call on ValI(A). the function may be a composite function.
	/// 
	/// Note this is only a call expression. it doesn't execute. 
	/// 
	/// 
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	/// <remarks>
	/// Note: It's a morphism from one set to the other. The implementated ExprI(ValI(R)) is not ommitable. 
	/// And this type is a magma. So it's better a seperate type rather expr(A,R). In this way, we have a new domain and leave the small one, expr(r), intact closed.
	/// </remarks>
	public partial class UnaOpCallVal<A,R>
		:UnaOpCallA<UnaOpI<A,R>,ExprI<ValI<A>>>
		,
		ExprI<ValI<R>>
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg">the vals: literal, or var</param>
		/// <param name="op">the op: parameter type: P, return type:R </param>
		public UnaOpCallVal( UnaOpI<A,R> op,ExprI<ValI<A>> arg)
			:base(op,arg)
		{
			
		}
					






	}
}
