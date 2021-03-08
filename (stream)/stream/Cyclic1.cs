using nilnul.str.to;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream
{
	public class Cyclic1<T> : nilnul._stream.NextI<T>
	{
		private nilnul.str.SeededI<T> _started;

		public nilnul.str.SeededI<T> started
		{
			get { return _started; }
			set { _started = value; }
		}


		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			set { _enumerator = value; }
		}




		public Cyclic1(nilnul.str.SeededI<T> started)
		{
			_started = started;
			_enumerator = _started.ToEnumerable().GetEnumerator();
			//_enumerator.Reset();
		}



		
		public  T next()
		{

			
			if (!_enumerator.MoveNext())
			{
				_enumerator.Reset();
				_enumerator.MoveNext();

			}
			return _enumerator.Current;



			throw new NotImplementedException();
		}
	}
}
