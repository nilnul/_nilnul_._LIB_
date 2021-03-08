using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface ExprI1:_expr_.BlankI
	{
	}

	public interface ExprI1<out T> : ExprI1
	{
	}
}
