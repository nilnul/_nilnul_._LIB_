using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public partial interface OpCallI_R<OpR> : 
		
		OpCallI<OpI<OpR>>
		
		,ExprI<OpR>
		
	{
		
	}
}
