using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{


	public class Be_froFunc<T> : BeI<T>
	{

		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Be_froFunc(Func<T,bool> func)
		{
			_func = func;
		}

		public bool be(T obj)
		{
			return _func(obj);

			throw new NotImplementedException();
		}
	}







}
