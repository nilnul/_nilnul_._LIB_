using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._slider_;

namespace nilnul.slider_
{
	public class FroFunc<T>
		:
		slider.Cast<BigInteger,T>,
		_slider_.SliderI<T>
	{
		public FroFunc(  Func<BigInteger, T> caster) : base(new slider_.Natural_froBigInt(), caster)
		{
		}

		 
	}
}
