using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	[Obsolete("nilnul.be")]
	public partial class Asserted<T, TB>
		where TB : BeI<T>, new()
	{
		static public Assert_TbDefault<T, TB> Assert = SingletonByDefaultNew<Assert_TbDefault<T, TB>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}


		public Asserted(T val)
		{
			Assert.assert(val);
			this._val = val;

		}


	}



}
