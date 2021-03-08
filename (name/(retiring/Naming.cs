using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{

	public struct Naming
	{
		private Var1 _var;

		public Var1 var
		{
			get { return _var; }
			set { _var = value; }
		}

		private nilnul.txt.be.Name.Asserted _name;

		public nilnul.txt.be.Name.Asserted name
		{
			get { return _name; }
			set { _name = value; }
		}



	}
}
