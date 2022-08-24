using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._expr_
{
	

	public  interface SubstituteI< in TVar, in TVal, out TRet >
	{
		TRet substitute( TVar var, TVal expr);

	}


	
	public  interface SubstituteI<T, in TVar, in TVal, out TRet>
		:SubstituteI<TVar,TVal, TRet>

		where TVar:nilnul.VarI2<T>
		where TVal:nilnul.ExprI1<T>
		
	{
 
	}

	


	



}
