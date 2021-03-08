using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public abstract class AssertA<T> : AssertI<T>
	{

		public abstract void assert(T obj);
	}
}
