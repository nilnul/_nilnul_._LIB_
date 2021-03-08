using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._expr_
{
	public  interface VarsI<TVars>
		where TVars: nilnul.var._set_.BlankI

	{
		
		TVars vars { get; }

	}

}
