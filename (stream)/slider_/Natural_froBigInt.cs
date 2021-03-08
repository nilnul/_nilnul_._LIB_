using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slider_
{
	public class Natural_froBigInt : _slider_.SliderI<BigInteger>
	{

		private BigInteger _current = 0;
		public BigInteger current
		{
			get
			{
				return _current;
 			}
		}

		public void moveNext()
		{
			_current++;
 		}
	}
}
