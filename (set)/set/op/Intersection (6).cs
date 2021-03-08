using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.linearAlgebra;

namespace nilnul.set.operation
{
	public class Intersection
	{
		public Set[] sets;
		public Intersection(Set[] sets) {
			this.sets = sets;
		}
		public override string ToString()
		{
			return "*("+sets.toString()+")";
		}
	}
}
