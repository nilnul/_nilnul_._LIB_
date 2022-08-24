using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._op
{
	public interface EvalI<in P,out R>
	{
		R eval(P arg);
	}
}
