using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.be_
{
	public class Dwelt<T> : BeI<T>
	{
		public bool be(HashSet<T> obj)
		{
			return obj.Any();
			//throw new NotImplementedException();
		}

		static public Dwelt<T> Singleton
		{
			get
			{
				return nilnul.Singleton1<Dwelt<T>>.Instance;
			}
		}

	}

	public class Dwelt<T, TEq> : BeI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public bool be(Set1<T, TEq> obj)
		{
			return obj.Any();
			//throw new NotImplementedException();
		}


		static public Dwelt<T,TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Dwelt<T,TEq>>.Instance;
			}
		}

	}
}
