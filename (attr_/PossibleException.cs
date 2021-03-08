using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("Possible exception; use with care, and read the internal algorithm or docs. This might be intended to be used in lazy expression")]
	public class PossibleExceptionAttribute : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public PossibleExceptionAttribute(string comment="")
		{
			Comment = comment;
		}

	}
}
