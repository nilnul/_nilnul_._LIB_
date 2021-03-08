using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Assert<T>
	{
		Func<T, bool> _func;

		public Func<T, bool> func {

			get {
				return _func;
			}
			
		}

		public Assert(Func<T,bool> func)
		{
			this._func = func;
		}

		public void yes(T obj) {

			AssertX.True(_func(obj));
			
		}
		public void no(T obj) { 
			AssertX.False(_func(obj));
		}
					
	}
}
