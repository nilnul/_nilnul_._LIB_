using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using nilnul.lang.op.expr;
//using nilnul.lang.op.list.expr;

namespace nilnul.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"> operands </typeparam>
	/// <typeparam name="U"> where the operator can operate on.</typeparam>
	/// 
	[Obsolete("use MultiOpExprI<TOpArg,TOpResult,TArg>")]
	public partial interface ListOpCallI<A,Op> : ListOpCallI_Op<Op>, ListOpCallI_A<A> 
		where Op:ListOpI
		

	
		
	{

		//IEnumerable<TOperands> operands
		//{
		//    get;
		//    set;
		//}

		//MultiOpI<TOpOperands> op
		//{
		//    get;
		//    set;
		//}
	}
}
