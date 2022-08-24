using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	static public class NotNullX
	//where T : class //The type argument must be a reference type; this applies also to any class, interface, delegate, or array type.
	{

		
		static public NotNull2<T> ToNotNull<T>(this T val)
		{
			return new NotNull2<T>(val);
		}

		static public bool IsNull(this object obj) {
			if (obj==null)
			{
				return true;
				

			}
			return false;
		}

		static public bool IsNotNull(this object obj)
		{
			if (obj == null)
			{
				return true;


			}
			return false;
		}

		static public void AssertIsNull(this object obj) {
			if (IsNotNull(obj))
			{
				throw new NullReferenceException();
				
			}
			return;
		}

		static public void AssertIsNotNull(this object obj)
		{
			if (IsNull(obj))
			{
				throw new NullReferenceException();

			}
			return;
		}

		static public T EnsureNotNull<T>(this T value)
		{
			AssertIsNotNull(value);
			return value;
		}
	


	}
}
