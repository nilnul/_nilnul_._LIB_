using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	//[Obsolete("Place holder for a knowledge or name")]
	public class ReturnNull : System.Attribute

	{
		//#warning
		//#pragma message ( "text" )

		public string Comment;

		public ReturnNull(string comment="")
		{
			Comment = comment;
		}

	}
}
