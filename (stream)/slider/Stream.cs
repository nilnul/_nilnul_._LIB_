using nilnul._stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slider
{
	public class Stream<T>
		:nilnul.Box1<_slider_.SliderI<T>>
		,
		StreamI<T>
	{
		public Stream(_slider_.SliderI<T> val):base(val)
		{

		}

		public T next()
		{
			var t = boxed.current;
			boxed.moveNext();
			return t;
			//throw new NotImplementedException();
		}
	}
}
