using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._opt
{
	[Obsolete("nilnul.obj")]
	public class One<T>:ValI<T>,OneI
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public One(T val)
		{
			_val = val;
		}
		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
