using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream
{

	public class StrAsStream<T>:_stream.NextI<T>
		where T :class
	{
		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			//set { _enumerator = value; }
		}


		public StrAsStream(IEnumerable<T> str)
		{
			_enumerator = str.GetEnumerator();
		}

		public T next()
		{
			return _enumerator.MoveNext() ? _enumerator.Current : null;

			throw new NotImplementedException();
		}


	}


}
