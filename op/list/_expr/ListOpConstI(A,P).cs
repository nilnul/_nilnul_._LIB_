using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public interface ListOpConstI<A,P>
		:
		ConstI, ListOpExprI<A, P>
		where A:ConstI<P>


	{


	}
}
