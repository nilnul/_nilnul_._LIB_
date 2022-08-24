using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op_
{
	public interface UnaryI<out TResult, in TArg>
	{
		TResult op(TArg arg);
	}

}
