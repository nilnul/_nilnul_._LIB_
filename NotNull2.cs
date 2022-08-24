using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public struct NotNull2<T>
	//where T : class //The type argument must be a reference type; this applies also to any class, interface, delegate, or array type.
	{

		private T _val;
		public T val
		{
			get
			{
				assertNotNull();
				return _val;
			}
			set
			{
				AssertNotNull(value);

				_val = value;
			}

		}

		public void assertNotNull()
		{
			AssertNotNull(_val);
		}
		static public void AssertNotNull(T val)
		{
			if (val == null)
			{
				throw new ArgumentNullException();

			}
		}

		public NotNull2(T val)
		{
			this._val = val;
			assertNotNull();

		}

		static public T EnsureNotNull(T value) {
			AssertNotNull(value);
			return value;
		}

		static public NotNull2<T> ToNotNull(T value)
		{
			return new NotNull2<T>(value);

		}

		public static implicit operator NotNull2<T>(T value)
		{
			return new NotNull2<T>(value);
		}

		public static implicit operator T(NotNull2<T> wrapper)
		{
			return wrapper.val;
		}


	}
}
