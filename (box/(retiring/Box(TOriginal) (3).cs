using System;
using System.Net;

namespace nilnul
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public partial class Box<TOriginal>
	{
		public TOriginal val;

		public Box(TOriginal val)
		{
			this.val = val;
		}
		public Box() { }
					

		public TOriginal toOriginal() {

			return this.val;
		}

		static public implicit operator TOriginal(Box<TOriginal> a) {
			return a.val;
		}
		static public implicit operator Box<TOriginal>(TOriginal a) {
			return new Box<TOriginal>(a);
		}

	}

	static public partial class X {

		static public TOriginal To<TOriginal,TTo>(this TTo a)
			where TTo:Box<TOriginal>,new()
		{
			var r = new TTo();
			r.val = a;
			return r;
		}
		
	}
}
