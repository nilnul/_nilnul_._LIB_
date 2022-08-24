using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public abstract class EqA<T> : IEqualityComparer<T>
	{
		public bool ne(T x, T y) {
			return !Equals(x, y);
		}
		[Obsolete("ne")]
		public bool Ne(T x, T y) {
			return !Equals(x, y);
		}

		public abstract bool Equals(T x, T y);

		public abstract int GetHashCode(T obj);
	}

	public abstract class EqA_constHash<T> : EqA<T>
	{


		public override int GetHashCode(T obj)
		{
			return 0;
		}


	}

	public class FuncAsEq<T> :

		EqA_constHash<T>    /* same elements should return same code*/
	{
		private Func<T,T,bool> _func;

		public Func<T,T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public FuncAsEq(Func<T,T,bool> func)
		{
			_func = func;
		}
		public override bool Equals(T x, T y)
		{
			return _func(x, y);
			throw new NotImplementedException();
		}
	}





}
