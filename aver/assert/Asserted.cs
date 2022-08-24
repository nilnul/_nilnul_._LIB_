using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.assert
{

	public class Asserted_assertDefault<T,TAssert>:Asserted<T,TAssert>
		where TAssert:nilnul.AssertI<T>,new()
	{
		public Asserted_assertDefault(T val):base(
			SingletonByDefault<TAssert>.Instance, val	
		)
		{

		}

	}

	public class Asserted<T,TAssert>
		where TAssert:nilnul.AssertI<T>
	{
		private AssertI<T> _assert;

		public AssertI<T> assert
		{
			get { return _assert; }
			set { _assert = value; }
		}

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}



		public Asserted(AssertI<T> assert, T val)
		{
			assert.assert(val);

			_assert = assert;
			_val = val;
		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
