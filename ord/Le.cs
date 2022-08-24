using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.ord
{
	public class EqFroLe_leDefault<T, TLe> 
		: 
		EqFroLe<T,TLe>

		where TLe : LeA<T>,new()
	{
		public EqFroLe_leDefault():base(SingletonByDefault<TLe>.Instance)
		{

		}

	}

	public class EqFroLe<T, TLe> 
		: IEqualityComparer<T>
		where TLe : LeA<T>,new()
	{

		private TLe _le;

		public TLe le
		{
			get { return _le; }
			set { _le = value; }
		}
		public EqFroLe(TLe le)
		{
			_le = le;
		}
		public bool Equals(T x, T y)
		{
			return _le.eq(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}

	}

	public abstract class LeA<T> : LeI<T>
	{
		public abstract bool le(T x, T y);

		public bool ge(T x, T y) {
			return le(y, x);

		}

		public bool eq(T x, T y) {
			return le(x, y) && ge(x, y);

		}

		public bool ne(T x, T y) {
			return !eq(x, y);

		}

		public bool lt(T x, T y) {
			return le(x, y) && ne(x, y);

		}

		public bool gt(T x, T y) {
			return ge(x, y) && ne(x, y);

		}

		public EqComparer createComparer() {
			return new EqComparer(this);
		}

		public class EqComparer:IEqualityComparer<T>
		{
			private LeA<T> _le;

			public LeA<T> le
			{
				get { return _le; }
				set { _le = value; }
			}

			public EqComparer(LeA<T> le)
			{
				_le = le;
			}

			public bool Equals(T x, T y)
			{
				return _le.eq(x, y);
				throw new NotImplementedException();
			}

			public int GetHashCode(T obj)
			{
				return obj.GetHashCode();
				throw new NotImplementedException();
			}
		}








	}

	public interface LeI<T>:LeI<T,T>
	{
	}


	public interface LeI<T,T1>
	{
		bool le(T x, T1 y);
	}
}
