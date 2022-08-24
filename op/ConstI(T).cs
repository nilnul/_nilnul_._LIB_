using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	/// <summary>
	/// an expression with all literals.
	/// </summary>
	 //[Obsolete("use nilnul.op.ConstI")]
	public partial interface ConstI<out T> : ExprI<T>,  ConstI
	{

//		T eval();
	}

	
}
