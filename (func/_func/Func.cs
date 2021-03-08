using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._func
{
	public interface FuncI< TInput, out TExpr>
		:ExprAsMemberI<TExpr>
		
		,InputI<TInput>

	{

	}

	public class Func<TInput, TExpr> :

		
		_func.Input<TInput>
		,
		
		FuncI<TInput, TExpr>
	{
		private TExpr _expr;
		public TExpr expr
		{
			get
			{
				return _expr;
				throw new NotImplementedException();
			}
		}


		public Func(TInput input, TExpr expr):base(input)
		{
			_expr = expr;

		}

		public override string ToString()
		{
			return $"({input})=>({_expr})";
        }
	}




	public class Func_typeParaConstrained<TInput, TExpr> :

		Func<TInput,TExpr>
		where TInput : nilnul.var.TuplI
		where TExpr:nilnul.ExprI1
		
	{
		
		public Func_typeParaConstrained(TInput input, TExpr expr):base(input,expr)
		{

		}
	}



}
