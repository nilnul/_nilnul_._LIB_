using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var_
{
	public class Typed
		:
		nilnul.IVar
		,
		_typed_.TypeI
		
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Typed(Type type)
		{
			_type = type;

		}

		//public Typed(ParameterExpression param):this(param.Type)
		//{

		//}
		static public ParameterExpression  Ov(Typed typed)=> Expression.Parameter(typed.type);

		 public ParameterExpression  toPar()=> Expression.Parameter(this.type);

	}
}
