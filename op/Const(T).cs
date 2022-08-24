using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.op
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Const<T> : ConstI<T>
	{
		public T val;

		public Const(T val)
		{
			this.val = val;
		}
	

		static public implicit operator T(Const<T> a) {
			return a.val;
		}
		static public implicit operator Const<T>(T a) {
			return new Const<T>(a);
		}


		public T eval()
		{
			return val;
		}

		public ConstantFunction<T> function {
			get {
				return new ConstantFunction<T>(val);
			}
		}

		public HashSet<object> args {
			get {
				return new HashSet<object>();
			}
		}


	}

	static public partial class ConstX {

		static public Const<TSource> ToLiteral<TSource>(this TSource a)
			
		{

			return (a);
		}
		
	}
}
