using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public interface ListOpExprI<A,P,R>
		:
		
		ListOpCallI<A,ListOpI<P,R>>
		,
		ExprI<R>,
		
		ListOpExprI<A, P>

		where A:ExprI<P>


	{


	}
}
