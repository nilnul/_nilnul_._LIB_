using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.vow
{
	public abstract class EnA<T>
		: EnI<T>
	{
		
		public EnA( T val)
		{
			_en = val;


		}

		private T _en;


		public T en {
			get {
				return _en;
			}
		}

		public override string ToString()
		{
			return _en.ToString();
		}

		static public implicit operator T(EnA<T> en) { return en.en; }
	}
}
