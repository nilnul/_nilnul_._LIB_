using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._func
{


	public  interface ExprAsMemberI< out TExpr>
	{

		TExpr expr { get; }

	}

	public abstract class ExprAsMemberA<TExpr>
	:
	ExprAsMemberI<TExpr>



	{
		private TExpr _expr;

		public TExpr expr
		{
			get { return _expr; }
			set { _expr = value; }
		}


		public ExprAsMemberA(TExpr expr)
		{
			_expr = expr;
		}
	}


}
