using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.func._stati;
using nilnul.obj.var;
using nilnul.obj.var.stati;
using nilnul.obj.var.stati.s.b;
using nilnul.obj.var.stati.set;
using nilnul.obj.var.stati.s;

namespace nilnul.func
{

	public interface ExprAsFuncI {


	}

	public class ExprAsFunc<TExpr>
		:

		_func.ExprAsMemberA<TExpr>

		

	{
		public ExprAsFunc(TExpr expr):base(expr)
		{

		}
	}
}
