using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.eq
{
	public class EqContext<T,TEq>
		where TEq:IEqualityComparer<T>
	{
		private TEq _eq;

		public TEq eq
		{
			get { return _eq; }
			set { _eq = value; }
		}


		public EqContext(TEq eq)
		{
			_eq = eq;
		}

		public class Element
		{

			private T _val;

			public T val
			{
				get { return _val; }
				set { _val = value; }
			}

			public Element(T val)
			{
				_val = val;
			}

			

		}
	}
}
