using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public struct RefNotNullStruct<T>
		where T : class //The type argument must be a reference type; this applies also to any class, interface, delegate, or array type.
	{

		

		private T _val;
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

		public RefNotNullStruct(T val)
		{
			this._val = val;

		}

		public static implicit operator RefNotNullStruct<T>(T value)
		{
			return new RefNotNullStruct<T>(value);
		}

		public static implicit operator T(RefNotNullStruct<T> wrapper)
		{
			return wrapper.val;
		}


	}
}
