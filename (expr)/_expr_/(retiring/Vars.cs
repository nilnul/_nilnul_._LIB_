using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._expr
{
	[Obsolete("nilnul.obj._expr_")]
	public  interface VarsI<TVars>

	{
		
		TVars vars { get; }

	}
	[Obsolete()]
	public  interface VarsI
		:VarsI<var.Set_ofVarI>
	{
		

	}


}
