using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op_
{
	public interface BinaryI<out TResult, in TArg,in TArg1>
	{
		TResult op(TArg arg, TArg1 arg1);
	}

}
