using System;
using System.Net;

namespace nilnul.function.nullary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Expr<T> : nilnul.function.ExprI<T>
	{
		public T val;

		public Expr(T val)
		{
			this.val = val;
		}
	

		static public implicit operator T(Expr<T> a) {
			return a.val;
		}
		static public implicit operator Expr<T>(T a) {
			return new Expr<T>(a);
		}


		public T eval()
		{
			return val;
		}

		public NullaryFunction<T> function {
			get {
				return new NullaryFunction<T>(val);
			}
		}

		public NullaryTuple<T> args{
			get {
				return NullaryTuple<T>.Instance;
			}
		}


	}

	
}
