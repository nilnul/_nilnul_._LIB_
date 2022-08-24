using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	public partial class Or:BinaryI
	{

		static private readonly Or _Instance = new Or();
		static public Or Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Or()
		{
		}
				
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 || operand2;
		}
	}
}
