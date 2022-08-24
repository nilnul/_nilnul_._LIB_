using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	
	[Obsolete()]

	public interface ExprI_withMembers : ExprI1,_expr.VarsI

	{


	}


	
	[Obsolete()]
	public interface ExprI_membered<out T> : ExprI_withMembers,ExprI1<T>,_expr.ReduceI_TInExpr<T>,_expr.SubstituteI1<T>,_call.OpI_generic
	{

	}



}
