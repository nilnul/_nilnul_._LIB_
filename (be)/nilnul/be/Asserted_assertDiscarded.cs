using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{
	public partial class Asserted_assertDefaultDiscarded<T, TBe>
		:nilnul.Asserted_assertDefaultDiscarded<T,nilnul.be.Assert_TbeDefault<T, TBe> >
		where TBe : BeI<T>, new()
	{

				


		public Asserted_assertDefaultDiscarded(T val):base(val)
		{
			

		}
	}



}
