using nilnul._stream;
using nilnul.str.to;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream
{
	public class Sentinel<T>:StreamI,_stream.NextI<T>
	{
		private StrI1<T> _str;

		public StrI1<T> str
		{
			get { return _str; }
			set { _str = value; }
		}

		private T _sentinel;

		public T sentinel
		{
			get { return _sentinel; }
			set { _sentinel = value; }
		}

		public Sentinel(StrI1<T> str, T sentinel)
		{
			_str = str;
			_sentinel = sentinel;

			_enumerator = _str.ToEnumerable().GetEnumerator();
		}

		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			set { _enumerator = value; }
		}


		public T next()
		{

			if (_enumerator.MoveNext())
			{
				return _enumerator.Current;
			}
			else
			{
				return _sentinel;
			}
			


			throw new NotImplementedException();
		}
	}
}
