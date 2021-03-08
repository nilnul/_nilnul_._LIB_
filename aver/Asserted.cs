using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete("nilnul.obj")]
	public class Asserted_assertDefaultDiscarded<T,TAssert>:Asserted_assertDiscarded<T,TAssert>
		where TAssert:nilnul.AssertI<T>,new()
	{
		public Asserted_assertDefaultDiscarded(T val):base(
			SingletonByDefault<TAssert>.Instance, val	
		)
		{

		}

	}
	[Obsolete("nilnul.obj.Avow.Ed")]

	public class Asserted_assertDiscarded<T,TAssert>
		where TAssert:nilnul.AssertI<T>
	{
		

		private T _asserted;

		public T asserted
		{
			get { return _asserted; }
			set { _asserted = value; }
		}



		public Asserted_assertDiscarded(AssertI<T> assert, T val)
		{
			assert.assert(val);

			_asserted = val;
		}

		public override string ToString()
		{
			return _asserted.ToString();
		}
	}
}
