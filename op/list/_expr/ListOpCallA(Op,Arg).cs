using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.op
{

	/// <summary>
	/// to be inherited by an expr of a specific operator, such as an add expr.
	/// </summary>
	/// <typeparam name="TOperands"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	public abstract partial class ListOpCallA<Arg, Op> 
		
		: UnaOpCallA<IList<Arg>,Op>

		where Op:ListOpI
		
	
	{

		public ListOpCallA(Op op, params Arg[] args)
			:base(args,op)
		{
		}
					



	





	}

}
