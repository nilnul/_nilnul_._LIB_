using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nulable
{
	public  class Eq<T> : nilnul.Box1<IEqualityComparer<T>>, IEqualityComparer<T>
	{
		public Eq(IEqualityComparer<T> eq):base(eq)
		{

		}
		public bool Equals(T x, T y)
		{
			if (x==null)
			{
				if (y==null)
				{
					return true;
				}
				return false;
			}
			return boxed.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			if (obj==null)
			{
				return 0;
			}

			return this.boxed.GetHashCode(obj);
			//throw new NotImplementedException();
		}
	}

	public class Eq<T,TEq> :Eq<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Eq():base(nilnul.Singleton1<TEq>.Instance)
		{

		}

		static public Eq<T,TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Eq<T,TEq>>.Instance;
			}
		}

	}


}
