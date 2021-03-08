using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("use this interface is not wrong; but you shall use the umbrella class or struct, which inherits and boxes the interface such that operator override, etc, works.")]
	public class UseClassOrStructAttribute : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string comment;

		public UseClassOrStructAttribute(string comment="")
		{
			this.comment = comment;
		}

	}
}
