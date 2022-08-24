using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.optional_
{
	public class None<T>:OptionalI<T>,NoneI
	{
		public override string ToString()
		{
			return "";
		}
	}
}
