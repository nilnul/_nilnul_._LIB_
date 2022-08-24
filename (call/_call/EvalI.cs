using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._call
{
	public interface EvalI<out TR>
	{

		TR eval();
	}
}
