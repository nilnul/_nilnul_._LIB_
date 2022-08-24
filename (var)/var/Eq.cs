using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var
{

	public class Eq1 : IEqualityComparer<nilnul.VarI2>
	{
		public bool Equals(VarI2 x, VarI2 y)
		{
			return x == y;
			//throw new NotImplementedException();
		}

		public int GetHashCode(VarI2 obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static public Eq1 Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq1>.Instance;
			}
		}

	}

	public class Eq<TVar> : IEqualityComparer<TVar>
		where TVar:nilnul.VarI2
	{
		public bool Equals(TVar x, TVar y)
		{

			return Eq1.Singleton.Equals(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(TVar obj)
		{
			return Eq1.Singleton.GetHashCode(obj);
			throw new NotImplementedException();
		}

		static public Eq<TVar> Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq<TVar>>.Instance;
			}
		}

	}
}
