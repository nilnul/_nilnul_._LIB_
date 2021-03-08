using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._opt
{
	public class None<T>:ValI<T>,NoneI
	{
		public override string ToString()
		{
			return "";
		}
	}
}
