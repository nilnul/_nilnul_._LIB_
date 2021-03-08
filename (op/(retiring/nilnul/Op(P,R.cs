using nilnul.obj;
//using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Op<P,R>
		:OpI<P,R>
	{

		private Func<P,R> _func;

		public Func<P,R> func
		{
			get { return _func; }
			set { _func = value; }
		}



		public Op(Func<P,R> op)
		{
			_func = op;
		}


		public R eval(P a)
		{
			return _func(a);

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return  NamingContext.Name(this)??base.ToString();
		}
	}
}
