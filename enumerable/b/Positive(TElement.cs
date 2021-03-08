using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.enumerable.b
{
	public partial class Headed<TElement>
		:BeI<IEnumerable<TElement>>
	{

		static public bool Be(IEnumerable<TElement> val) {

			return (val.Count()>0);
		
		}

		public bool be(IEnumerable<TElement> obj)
		{
			return (obj.Count() > 0);
			throw new NotImplementedException();
		}

		public class Asserted:nilnul.Asserted<IEnumerable<TElement>, Headed<TElement>>
		{

			public Asserted(IEnumerable<TElement> val):base(val)
			{

			}
		}



	}


}
