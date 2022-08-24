using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream.to
{
	public class Enumerable<T>:

		nilnul.enumerable.AsEnumerableA<T>,
		
		IEnumerable<T>
	{
		private nilnul._stream.NextI<T> _next;

		public nilnul._stream.NextI<T> next
		{
			get { return _next; }
			set { _next = value; }
		}

		public Enumerable( nilnul._stream.NextI<T> next)
		{
			_next = next;
		}

		public override IEnumerator<T> GetEnumerator()
		{
			while (true)
			{
				yield return next.next();

			}

			
			//throw new NotImplementedException();
		}

		
	}
}
