using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream_.seq_
{

	public class DefaultAppended<T>
		:
		
		_stream_.NextI<T>
		where T :class
	{
		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			//set { _enumerator = value; }
		}


		public DefaultAppended(IEnumerable<T> str)
		{
			_enumerator = str.GetEnumerator();
		}

		public T next()
		{
			return _enumerator.MoveNext() ? _enumerator.Current : default(T);

			//throw new NotImplementedException();
		}


	}


}
