using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// an expression with at least one var.
	/// </summary>
	public partial interface ValI<out T> : VarExprI
	{
	}
}
