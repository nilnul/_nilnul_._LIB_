using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{

	/// <summary>
	/// op returning a value of type R
	/// </summary>
	/// <typeparam name="R">the "out" is meant for some type can be regarded as derived from it.</typeparam>
	public partial interface UnaOpI_R<out R>
		: UnaOpI, OpI<R>

	{

	}
}
