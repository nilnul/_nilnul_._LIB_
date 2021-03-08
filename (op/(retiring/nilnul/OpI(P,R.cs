using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	[Obsolete("nilnul.obj")]
	public interface OpI<T>
		:OpI<T,T>, _op.EvalI<T>
	{

	}

	[Obsolete()]
	public interface OpI<in P,out R>
		:
		_op.EvalI<P,R>
		, OpI
	{

	}
	[Obsolete()]
	public interface OpI_RHead<out R, in P>
		:_op.EvalI<P,R>
		//,
		//obj.OpI_mono
	{

	}


}
