using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

//using nilnul.lang.op.binary;

namespace nilnul.element.collection.set
{
	public partial class SetBinaryOpExpr
	   : SetBinaryOpExprA
	{




		public override BinaryOpI<SetI, SetI, SetI> op
		{
			get;
			set

			;
		}

		public SetBinaryOpExpr(SetI a, SetI b,BinaryOpI<SetI, SetI, SetI> op)
			: base(a, b)
		{
			this.op = op;

		}


		
	}
}
