using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._opt.one
{
	public class Eq<T>
		: IEqualityComparer<One<T>>
	{
		private IEqualityComparer<T> _valEq;

		public IEqualityComparer<T> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}

		public Eq(IEqualityComparer<T> eq)
		{
			_valEq = eq;

		}
		public bool Equals(One<T> x, One<T> y)
		{
			return _valEq.Equals(x.val, y.val);
			//throw new NotImplementedException();
		}

		public int GetHashCode(One<T> obj)
		{
			return _valEq.GetHashCode(obj.val);

			//throw new NotImplementedException();
		}
	}
}
