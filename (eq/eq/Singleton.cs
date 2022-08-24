using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.eq
{
	public class Singleton<T, TEq>
		:
		EqA<T>,
		
		IEqualityComparer<T>
		where TEq :IEqualityComparer<T>,new()
	{
		static public Singleton<T, TEq> Singleton1 = SingletonByDefault<Singleton<T, TEq>>.Instance;

		static public TEq Eq = SingletonByDefault<TEq>.Instance;

		public override bool Equals(T x, T y)
		{
			return Eq.Equals(x, y);
			throw new NotImplementedException();
		}

		public override int GetHashCode(T obj)
		{
			return Eq.GetHashCode(obj);
			throw new NotImplementedException();
		}


	}
}
