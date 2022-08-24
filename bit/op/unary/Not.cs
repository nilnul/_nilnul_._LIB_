using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.unary
{
	public partial class Not
		:UnaryI
	{

		public bool exec(bool operand)
		{
			return !operand;
		}
	}
}
