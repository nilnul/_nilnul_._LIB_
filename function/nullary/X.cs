using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.function.nullary
{
	static public partial class ConstX
	{

		static public Expr<TSource> ToExpr<TSource>(this TSource a)
		{

			return (a);
		}

	}
}
