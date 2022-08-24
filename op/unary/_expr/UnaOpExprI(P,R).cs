using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// If the type of its argument is A; the type of its op is Op
	/// </summary>
	/// <typeparam name="R">the type of the returned value of the op</typeparam>
	/// <typeparam name="P">the type of the para of the op.</typeparam>
	public partial interface UnaOpExprI<P, R> 
		:ExprI<R>

	{
	}
}
