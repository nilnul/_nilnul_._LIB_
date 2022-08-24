using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	/// <summary>
	/// an operator which takes at least one para that of type P1.
	/// </summary>
	/// <typeparam name="P1"></typeparam>
	public partial interface OpI_P1<in P1> : OpI
	{
	}
}
