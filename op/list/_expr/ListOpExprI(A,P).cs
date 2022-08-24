using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public interface ListOpExprI<A,P>
		:
		
		ListOpCallI<A,ListOpI_P<P>>
		,
		ExprI
		where A:ExprI<P>


	{


	}
}
