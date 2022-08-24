using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{
	public class Set:nilnul.Set_eqDefault<Var1,nilnul.var.Eq>
		,SetI<Var1>
	{
		public Set()
		{

		}
		public Set(IEnumerable<Var1> vars):base(vars)
		{

		}
	}
	public class Set_ofVarI:nilnul.Set_eqDefault<VarI1,nilnul.var.Eq_ofVarI>
		,SetI
	{
		public Set_ofVarI()
		{

		}
		public Set_ofVarI(IEnumerable<Var1> vars):base(vars)
		{

		}

			public Set_ofVarI(params Var1[] vars):base(vars)
		{

		}
	public Set_ofVarI(IEnumerable<VarI1> vars):base(vars)
		{

		}
			public Set_ofVarI(params VarI1[] vars):base(vars)
		{

		}


	}

	public interface SetI<TVar>: System.Collections.Generic.ISet<TVar> {



	}


	public interface SetI : SetI<VarI1> {

	}




}
