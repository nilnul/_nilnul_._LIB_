using System;
using System.Net;

namespace nilnul
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	/// 
	//[Obsolete("nilnul.obj")]
	public  class Box1<TOriginal>
	{

		private TOriginal _boxed;

		public TOriginal boxed
		{
			get { return _boxed; }
			protected set { _boxed = value; }
		}


		public Box1(TOriginal val)
		{
			this._boxed = val;
		}
		
					

		public TOriginal toOriginal() {

			return this._boxed;
		}

		public override string ToString()
		{
			return _boxed.ToString();
		}

		static public implicit operator TOriginal(Box1<TOriginal> a) {
			return a._boxed;
		}
		static public implicit operator Box1<TOriginal>(TOriginal a) {
			return new Box1<TOriginal>(a);
		}

	}

}
