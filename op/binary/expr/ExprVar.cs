using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op.binary.expr
{
	public partial class ExprVar<A1,A2,R>
		:ArgsA<A1,A2>
		

	{
		private BiOpI<A1,A2,R> _op;

		public BiOpI<A1,A2,R> op
		{
			get { return _op; }
			set { _op = value; }
		}
		

		public ExprVar(A1 a1,A2 a2)
			:base(a1,a2)
		{
			this.op = op;
		}
					
	}
}
