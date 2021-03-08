using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_
{
	public interface EnumableI<out T>:StrI1<T>,IEnumerable<T>
	{

	}

	public class Enumable<T> : nilnul.Box1<IEnumerable<T>>, EnumableI<T>
	{
		public Enumable(IEnumerable<T> val) : base(val)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
