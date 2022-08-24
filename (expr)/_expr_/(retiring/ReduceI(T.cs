using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._expr
{
	/// <summary>
	/// try to demote to call
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 	
	[Obsolete()]

	public partial interface ReduceI_TInExpr< out T>
		:ReduceI<ExprI_membered<T>>
	{
		

	}

	[Obsolete()]

	public interface ReduceI<out T> {

		T reduce();

	}
}
