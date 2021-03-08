using System;
using System.Net;

namespace nilnul
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Literal<T> : LiteralI2<T>
	{
		public T val;

		public Literal(T val)
		{
			this.val = val;
		}
	

		static public implicit operator T(Literal<T> a) {
			return a.val;
		}
		static public implicit operator Literal<T>(T a) {
			return new Literal<T>(a);
		}


		public T eval()
		{
			return val;
		}
	}

	static public partial class LiteralX {

		static public Literal<TSource> ToLiteral<TSource>(this TSource a)
			
		{

			return (a);
		}
		
	}
}
