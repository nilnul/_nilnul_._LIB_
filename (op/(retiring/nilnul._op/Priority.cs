using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpI_generic = nilnul._op.OpI_generic;


namespace nilnul._op
{
	public partial class Priority 
	{

		static public Priority StaticInstance = new Priority();

		private List<Tuple<nilnul._op.OpI_generic,nilnul._op.OpI_generic>> _kernel=new List<Tuple<nilnul._op.OpI_generic, nilnul._op.OpI_generic>>();

		public List<Tuple<nilnul._op.OpI_generic,nilnul._op.OpI_generic>> kernel
		{
			get { return _kernel; }
			set { _kernel = value; }
		}




		public bool Le(nilnul._op.OpI_generic x, nilnul._op.OpI_generic y) {
			return _kernel.Contains(new Tuple<nilnul._op.OpI_generic, nilnul._op.OpI_generic>(x, y));

		}

		public bool Eq(nilnul._op.OpI_generic x, nilnul._op.OpI_generic y) {
			

			return Le(x,y) && Le( y,x);

		}
		public bool Ne(nilnul._op.OpI_generic x, nilnul._op.OpI_generic y) {


			return !Eq(x, y);

		}

		public bool Lt(nilnul._op.OpI_generic x, nilnul._op.OpI_generic y) {
			return Le(x, y) && Ne(x, y);
		}






	}
}
