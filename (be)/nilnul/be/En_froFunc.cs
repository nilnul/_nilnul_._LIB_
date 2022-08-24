using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.be
{

	[Obsolete()]
	public   class En_froFunc<T>
		
		
	{

		private T _val;

		public T val
		{
			get { return _val; }
			//set {

			//	_val = value;

			//}
		}





		public En_froFunc(T val ,Func<T,bool> func)
		{
			
			new nilnul.be.Avow_froFunc<T>(func).assert(val);
			_val = val;
			

		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}



}
