using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("Refactor Needed. Try to introduce the refactored subroutine")]
	public class RefactorNeededAttribute : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public RefactorNeededAttribute(string comment="")
		{
			Comment = comment;
		}

	}
}
