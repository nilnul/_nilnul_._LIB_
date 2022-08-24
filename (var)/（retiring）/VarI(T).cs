using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// it can be a named variable, or an expression called anonymous variable containing named variables and literals.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete("see (nilnul.obj)")]
	public  interface VarI<out T> : VarExprI<T>, VarI, ValI<T>
	{


	}
}
