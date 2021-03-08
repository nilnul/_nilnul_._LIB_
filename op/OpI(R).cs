using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.op
{
	/// <summary>
	/// An operator which returns TResult. Note the difference between Operator and Operator Expression.
	/// </summary>
	/// <typeparam name="TResult"></typeparam>
	public partial interface FunctionI<out TResult>
		: OpI
	{



	}

}

namespace nilnul.op
{
	/// <summary>
	/// An operator which returns TResult. Note the difference between Operator and Operator Expression.
	/// </summary>
	/// <typeparam name="TResult"></typeparam>
	public partial interface OpI<out TResult>
		: OpI
	{


	}
}

