using nilnul._stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slider
{
	public class Stream_skipHead<T>
		:nilnul.Box1<_slider_.SliderI<T>>
		,
		StreamI<T>
	{
		public Stream_skipHead(_slider_.SliderI<T> val):base(val)
		{

		}

		public T next()
		{
			
			boxed.moveNext();
			return boxed.current;
			//throw new NotImplementedException();
		}
	}
}
