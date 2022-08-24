using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// an expression with all literals.
	/// </summary>
	/// [=]
	/// 
	[Obsolete("use Literal")]
	public partial interface LiteralExprI<out T> : ExprI<T>, LiteralExprI
	{
	}
}
