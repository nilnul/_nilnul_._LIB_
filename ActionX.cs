using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class ActionX
	{
		static public void Eval(Action a) {
			if (a!=null)
			{
				a();
			}
		
		}
	}
}
