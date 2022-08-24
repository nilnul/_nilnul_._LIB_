using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// T, or VarI(T) or OpCallI(T)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface ExprI<out T>:ExprI
	{
	}
}
