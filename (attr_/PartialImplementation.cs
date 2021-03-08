using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("Partial implementation; If beyond range, possible exception will loom out; use with care, and read the internal algorithm or docs. This might be intended to be used in lazy expression")]
	public class PartialImplementationAttribute : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public PartialImplementationAttribute(string comment="")
		{
			Comment = comment;
		}

	}
}
