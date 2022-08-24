using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class Inf<T>:IComparable<T>
		where T:IComparable<T>
	{

		public int CompareTo(T other)
		{
			throw new NotImplementedException();
		}
	}
}
