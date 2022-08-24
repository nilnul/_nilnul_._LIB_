using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public struct NotNul<T>
	//where T : class //The type argument must be a reference type; this applies also to any class, interface, delegate, or array type.
	{

		private T _val;
		public T val
		{
			get
			{
				return _val;
			}
			set
			{
				Vow(value);
				_val = value;
			}

		}
		
		static public void Vow(T val)
		{
			if (val == null)
			{
				throw new ArgumentNullException();
			}
		}

		public NotNul(T val)
		{
				Vow(val);
				_val = val;
		}

		static public T Ensured(T value) {
			Vow(value);
			return value;
		}

		public static explicit operator NotNul<T>(T value)
		{
			return new NotNul<T>(value);
		}

		public static implicit operator T(NotNul<T> wrapper)
		{
			return wrapper.val;
		}
	}
}