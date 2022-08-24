using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public struct NotNull<T>
		where T : class //The type argument must be a reference type; this applies also to any class, interface, delegate, or array type.
	{

		

		private T _val ;
		public T val
		{
			get
			{
				if (_val==null)
				{
					throw new NullReferenceException();
					
				}
				return	_val;
			}
			set
			{
				if (val == null)
				{
					throw new ArgumentNullException();

				}
				_val = value;
			}

		}

		public NotNull(T val)
		{
			this._val = val;

		}

		public static implicit operator NotNull<T>(T value)
		{
			return new NotNull<T>(value);
		}

		public static implicit operator T(NotNull<T> wrapper)
		{
			return wrapper.val;
		}


	}
}
