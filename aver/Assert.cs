using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	
	[Obsolete("nilnul.obj.Avow")]
	public partial class Assert1
	{
		static public void True(bool x)
		{
			if (!x)
			{
				throw new Exception();

			}

		}

		static public void True(params bool[] xS) {
			xS.ForEach(x=>True(x));
		}

		static public void Same(object x, object y) {
			True(Object.Equals(x, y));
		}

		static public void False(bool x)
		{
			True(!x);
		}

		static public void Fail() {
			throw new Exception();
		}
	}


	/// <summary>
	/// assert given parameter must be something.
	/// </summary>
	/// 
	[Obsolete("nilnul.obj.Avow")]

	public partial class AssertX

	{
		/// <summary>
		/// this is not about logic. It just sees whether given argument is something pre-specified.
		/// </summary>
		/// <param name="x"></param>
		static public void True(bool x)
		{

			if (!x)
			{
				throw new Exception(string.Format("{0} is not true", x));

			}
		}
		static public void False(bool x)
		{

			if (x)
			{
				throw new Exception(string.Format("{0} is not false", x));

			}
		}

		static public void Eq<T>(T x, T y, IEqualityComparer<T> eq)
		{

			True(eq.Equals(x, y));

		}

		static public void Neq<T>(T x, T y, IEqualityComparer<T> eq)
		{

			False(eq.Equals(x, y));

		}

	}



	[Obsolete("nilnul.obj.Avow")]


	public interface AssertI<T>
	{
		void assert(T obj);
	}



}
