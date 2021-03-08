using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream
{
	public class Slider<T> : nilnul._slider_.SliderI<T>
	{
		private nilnul._stream_.NextI<T> _stream;

		public nilnul._stream_.NextI<T> stream
		{
			get { return _stream; }
			//set { _stream = value; }
		}



		public Slider(_stream_.NextI<T> stream)
		{
			_stream = stream;
			moveNext();
		}
		private T _current;
		public T current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current = _stream.next();
			//throw new NotImplementedException();
		}
	}
}
