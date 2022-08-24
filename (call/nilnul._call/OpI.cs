using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._call
{
	public interface OpI_generic
		:OpI<
			nilnul._op.OpI_generic
			>
	{
		
	}

	public interface OpI<T>
	{
		T op { get; }
	}

}
