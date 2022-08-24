using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{
	public class Set<TVar> : nilnul.Set1<TVar, Eq<TVar>>
		where TVar:nilnul.VarI2
		
	{
		public Set()
		{
		}

		public Set(IEnumerable<TVar> vals) : base(vals)
		{
		}
	}
}
