using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial class Imply:BinaryI
	{
		public bool exec(bool operand1, bool operand2)
		{
			return (!operand1) || operand2;
		}

		
	}
}
