using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;

namespace nilnul.op
{
	public partial class UnaOpConst<P,R, A>
		:
		UnaOpCallA<A,UnaOpI<P,R>>

		where A:ConstI<P>

	{

		
		public UnaOpConst( UnaOpI<P,R> op,A operand)
			:base(operand,op)
		{
			
			

		}






	}
}
