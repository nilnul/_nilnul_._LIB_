using System;
using System.Collections.Generic;
using System.Text;
using nilnul.function;

namespace nilnul.op
{
	/// <summary>
	/// If its op is Una(Op(P,R)), and its arg is A, while A is ExprI(P)
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	public partial interface UnaOpExprI<P, R, A>
		
		: 
		
		UnaOpCallI<A, UnaOpI<P,R>>
		,
		ExprI<R>
		where A:ExprI<P>

	{
		
	}
}
