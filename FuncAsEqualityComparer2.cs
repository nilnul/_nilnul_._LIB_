using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class FuncAsEqualityComparer2<T>: IEqualityComparer<T>
		
	{

		private Func<T,T,bool> _comparer;
		public FuncAsEqualityComparer2(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}







		public  bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public  int GetHashCode(T obj)
		{
			return 0;
		}
	}
}
