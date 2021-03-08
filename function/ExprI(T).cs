using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.function
{
	/// <summary>
	/// It's a function call with the arguments.
	/// </summary>
	/// <typeparam name="TResult">
	/// 
	/// </typeparam>
	/// 
	public partial interface ExprI<out TResult>:ExprI
	{
		/// <summary>
		/// eval the expr and get the result, which is of type T.
		/// </summary>
		/// <returns></returns>
		TResult eval();

	


	}
}
