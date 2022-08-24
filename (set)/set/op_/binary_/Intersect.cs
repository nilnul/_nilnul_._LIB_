using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	public class Intersect<T, TEq>
		:
		BinaryI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public Set1<T, TEq> op(Set1<T, TEq> arg, Set1<T, TEq> arg1)
		{
			var r = new Set1<T, TEq>(arg);
			r.IntersectWith(arg1);
			return r;
			
		}


		static public Intersect<T,TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Intersect<T,TEq>>.Instance;
			}
		}

	}


	public class Intersect<T, TEq, TSet>
		: BinaryI<T, TEq, TSet>
		where TEq : IEqualityComparer<T>, new()
		where TSet : nilnul.Set1<T, TEq>, new()
	{
		public TSet op(TSet arg, TSet arg1)
		{
			var r = new TSet();
			r.UnionWith(arg1);
			r.IntersectWith(arg1);
			return r;
			//throw new NotImplementedException();
		}


		static public Intersect<T, TEq, TSet> Singleton
		{
			get
			{
				return nilnul.Singleton1<Intersect<T, TEq, TSet>>.Instance;
			}
		}

	}
}
