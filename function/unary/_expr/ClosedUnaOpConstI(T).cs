using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul.op
{
	public partial interface ClosedUnaOpConstI<T>
		: ClosedUnaOpExprI<T>, UnaOpConstI<T, T, ConstI<T>>
	{

	}
}
