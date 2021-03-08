using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.element.collection.set
{
	public class Intersect 
		:SingleSignOp_A,
		IntersectI
	{

		public override char sign
		{
			get { return '*'; }
		}
	}
}
