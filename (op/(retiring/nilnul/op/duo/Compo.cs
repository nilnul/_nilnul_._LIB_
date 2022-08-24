using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op.duo
{
	public class Compo<TOp, T, T1, TOp1, T2>
		:nilnul._call.Call_ArgArg1A<TOp,TOp1>
		,nilnul.OpI<T,T2>
		where TOp :nilnul.OpI<T,T1>
		where TOp1 : nilnul.OpI<T1,T2>
	{

		public Compo(TOp op, TOp1 op1):base(op,op1)
		{

		}

		public T2 eval(T arg)
		{
			return this.arg1.eval(this.arg.eval(arg));
			throw new NotImplementedException();
		}
	}
}
