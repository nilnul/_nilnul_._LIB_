using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("May Perpetual; only use this if the given arg makes this not perpetual, or use this in a lazy expression.")]
	public class MayPerpetualAttribute : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public MayPerpetualAttribute(string comment="")
		{
			Comment = comment;
		}

	}
}
