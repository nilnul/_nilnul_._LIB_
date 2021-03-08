using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	[Obsolete()]
	public class B<T> : BI<T>
	{

		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public bool be(T obj)
		{
			return _func(obj);

			throw new NotImplementedException();
		}
	}

	[Obsolete()]
	public  interface BI<T>
	{
		bool be(T obj);
	}



}
