using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._expr
{
	[Obsolete()]
	public  interface SubstituteI1<out T >
	{
		ExprI_membered<T> substitute<V>( nilnul.VarI1<V> var, ExprI_membered<V> expr);

	}
	[Obsolete()]
	public  interface SubstituteI<out T, in V, in TArg >
	{
		T substitute( V var, TArg expr);

	}
	[Obsolete()]
	public  interface SubstituteI< in V,  T>:SubstituteI<T,V,T>
	{

	}


	



}
