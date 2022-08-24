using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	/// <summary>
	/// the operator returns a value of type R, and it has at least one para, which is of type P1
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A1"></typeparam>
	/// <remarks>
	/// R is placed before P1, because:
	///  1. R is meaningful more than P1.
	///  2. P1 and P2, etc is a sequence.
	/// 
	/// </remarks>
	public partial interface OpI_R_P1<out R,in P1>
		: OpI<R>, OpI_P1<P1>
	{

	}
}
