using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.opt
{
	public class Eq<T> : IEqualityComparer<nilnul.Opt<T>>
	{
		private nilnul._opt.one.Eq<T> _oneEq;

		public nilnul._opt.one.Eq<T> oneEq
		{
			get { return _oneEq; }
			set { _oneEq = value; }
		}

		public Eq(IEqualityComparer<T> valEq)
		{
			_oneEq = new _opt.one.Eq<T>(valEq);
		}
		public bool Equals(Opt<T> x, Opt<T> y)
		{
			if (x.val is nilnul._opt.One<T>)
			{
				if ( y.val is nilnul._opt.One<T>)
				{
					return _oneEq.Equals(x as nilnul._opt.One<T>, y as nilnul._opt.One<T>);

				}
				return false;

			}
			if (y.val is nilnul._opt.NoneI)
			{
				return true;

			}
			return false;

			//throw new NotImplementedException();
		}

		public int GetHashCode(Opt<T> obj)
		{

			if (obj.val is nilnul._opt.One<T>)
			{
				
					return _oneEq.GetHashCode(obj as nilnul._opt.One<T>);

			

			}
			
			return 0;
			//throw new NotImplementedException();
		}
	}
}
