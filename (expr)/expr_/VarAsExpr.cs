using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.expr_
{
	



	public class Var<TVar>
		
		//where TVar :VarI1
	{
		private TVar _var;

		public TVar var
		{
			get { return _var; }
			set { _var = value; }
		}

	

		public Var(TVar var)
		{
			_var = var;
		}

	
		
		public override string ToString()
		{
			return _var.ToString();
		}
	}
	public class Var<T, TVar> : Var<TVar>
		where TVar:nilnul.VarI2<T>
	{
		public Var(TVar var) : base(var)
		{
		}
	}

	

}
