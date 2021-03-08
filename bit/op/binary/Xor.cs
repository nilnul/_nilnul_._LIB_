using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	public class Xor:BinaryI
	{

		static private readonly Xor _Instance = new Xor();
		static public Xor Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Xor()
		{
		}
				
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 ^ operand2;
		}
	}
}
