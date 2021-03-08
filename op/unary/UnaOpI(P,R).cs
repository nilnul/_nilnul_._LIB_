using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// <remarks>
	/// this is a morphism so that the domain is on the left and the codomain is on the right.
	/// 
	/// </remarks>
	public partial interface UnaOpI<in P,out R> 
		: 
		UnaOpI_P<P>
		,
		UnaOpI_R<R>
	{
		R eval(P a);
	}
}
