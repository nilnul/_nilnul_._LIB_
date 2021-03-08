using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// 
	/// </summary>
	public  interface FuncI
	{

		
	}

	public interface FuncI<T, TPars,  TBody> : 
		FuncI
		,_func_.ParsI<TPars>
		,
		_func_.RuleI<TBody>

		where TPars: nilnul.var.SortieI<T>
		where TBody: nilnul.ExprI<T>

	{

	}


}
