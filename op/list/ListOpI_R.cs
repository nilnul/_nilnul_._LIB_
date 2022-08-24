using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{

	/// <summary>
	/// multiOp can operate on list, so it's ListOp
	/// e.g. * 
	/// </summary>
	/// <typeparam name="TArgs"></typeparam>
	public partial interface ListOpI_R<R>
		: 
		ListOpI,
		UnaOpI_R<R>
		
	{

	}
}
