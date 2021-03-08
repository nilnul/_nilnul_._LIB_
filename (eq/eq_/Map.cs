using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.eq_
{
	public class Map<TSrc, TTarget> :
		nilnul.Box1<IEqualityComparer<TTarget>>,
		IEqualityComparer<TSrc>
	{
		private Func<TSrc,TTarget> _map;

		public Func<TSrc,TTarget> map
		{
			get { return _map; }
			set { _map = value; }
		}

		public Map( Func<TSrc,TTarget> map, IEqualityComparer<TTarget> eq) :base(eq)
		{
			_map = map;
		}
		public bool Equals(TSrc x, TSrc y)
		{
			return boxed.Equals(_map(x),_map(y));

		//	throw new NotImplementedException();
		}

		public int GetHashCode(TSrc obj)
		{
			return boxed.GetHashCode(_map(obj));
		}
	}

	public class Map<TSrc,TTarget,TTargetEq>:Map<TSrc,TTarget>
		where TTargetEq:IEqualityComparer<TTarget>,new()
	{
		public Map(Func<TSrc,TTarget> map):base( map, nilnul.Singleton1<TTargetEq>.Instance)
		{

		}


		

	}
}
