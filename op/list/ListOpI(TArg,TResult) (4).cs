using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public interface ListOpI<TArg, TResult> 
		: ListOpI_P<TArg>
		, ListOpI_R<TResult>
	{

		
	}
}
