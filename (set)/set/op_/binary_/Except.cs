using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	public class Except<T, TEq>
		:
		BinaryI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public Set1<T, TEq> op(Set1<T, TEq> arg, Set1<T, TEq> arg1)
		{
			var r = new Set1<T, TEq>(arg);
			r.ExceptWith(arg1);
			return r;
			
		}


		static public Except<T,TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Except<T,TEq>>.Instance;
			}
		}

	}


	public class Except<T, TEq, TSet>
		: BinaryI<T, TEq, TSet>
		where TEq : IEqualityComparer<T>, new()
		where TSet : nilnul.Set1<T, TEq>, new()
	{
		public TSet op(TSet arg, TSet arg1)
		{
			var r = new TSet();
			r.UnionWith(arg1);
			r.ExceptWith(arg1);
			return r;
			//throw new NotImplementedException();
		}


		static public Except<T, TEq, TSet> Singleton
		{
			get
			{
				return nilnul.Singleton1<Except<T, TEq, TSet>>.Instance;
			}
		}

	}
}
