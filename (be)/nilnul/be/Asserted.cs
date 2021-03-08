using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{
	public partial class Asserted<T, TBe>
		:nilnul.assert.Asserted_assertDefault<T,Assert_TbeDefault<T, TBe> >
		where TBe : BeI<T>, new()
	{

		static public Assert_TbeDefault<T, TBe> Assert = SingletonByDefaultNew<Assert_TbeDefault<T, TBe>>.Instance;

		


		public Asserted(T val):base(val)
		{
			

		}
	}



}
