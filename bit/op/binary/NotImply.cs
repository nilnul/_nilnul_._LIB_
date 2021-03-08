using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	public partial class NotImply:BinaryI
	{

		static private readonly NotImply _Instance = new NotImply();
		static public NotImply Instance
		{
			get
			{
				return _Instance;
			}
		}
		private NotImply()
		{
		}
				

		public bool exec(bool a, bool b)
		{
			return NotImplyX.Eval(a, b);
		}
	}
}
