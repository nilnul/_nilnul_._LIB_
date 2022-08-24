using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var
{
	public class Le : IComparer<nilnul.VarI1>
	{
		private nilnul.var.set.NamingContext_ofVarI _naming;

		public nilnul.var.set.NamingContext_ofVarI naming
		{
			get { return _naming; }
			set { _naming = value; }
		}
		public Le(nilnul.var.set.NamingContext_ofVarI naming)
		{
			_naming = naming;
		}


		public int Compare(nilnul.VarI1 x, nilnul.VarI1 y)
		{
			return StringComparer.InvariantCulture.Compare(_naming.getEnsuredName(x), _naming.getEnsuredName(y));

			throw new NotImplementedException();
		}
	}
}
