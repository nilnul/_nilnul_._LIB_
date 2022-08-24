using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("Place holder for a knowledge or name")]
	public class Nominal : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public Nominal(string comment="")
		{
			Comment = comment;
		}

	}
}
