using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// Literal(T), or  or OpCallI(T)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	//[Obsolete("See op call in nilnul.op")]
	public partial interface ExprI<out T>:ExprI
	{

	}
}
