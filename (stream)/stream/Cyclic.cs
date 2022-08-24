using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream
{
	[Obsolete()]
	public class Cyclic<T> : nilnul._stream.StreamA<T>
	{
		private nilnul.str.Seeded<T> _started;

		public nilnul.str.Seeded<T> started
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




		public Cyclic(nilnul.str.Seeded<T> started)
		{
			_started = started;
			_enumerator = _started.GetEnumerator();
			//_enumerator.Reset();
		}

		
		public override T next()
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
