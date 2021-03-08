using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	[Obsolete()]
	/// <summary>
	/// Literal(T), or  or OpCallI(T)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	//[Obsolete("See (nilnul.obj)")]
	public  interface ExprI<out T>:ExprI
	{

	}
}
