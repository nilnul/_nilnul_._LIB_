using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul._slider_;

namespace nilnul.slider
{
	public class Cast<TOriginal, TTarget>
		: _slider_.SliderI<TTarget>
	{

		private _slider_.SliderI<TOriginal> _originalSlider;

		//public _slider_.SliderI<TOriginal> originalSlider
		//{
		//	get { return _originalSlider; }
		//	set { _originalSlider = value; }
		//}

		public Cast(_slider_.SliderI<TOriginal> sliderOriginal, Func<TOriginal, TTarget> caster)
		{
			_originalSlider = sliderOriginal;
			_func = caster;
		}

		private Func<TOriginal, TTarget> _func;

		//public Func<TOriginal,T> func
		//{
		//	get { return _func; }
		//	set { _func = value; }
		//}

		public TTarget current
		{
			get
			{
				return _func(this._originalSlider.current);
			}
		}

		public void moveNext()
		{
			_originalSlider.moveNext();
		}
	}
	public class Cast<T> : Cast<T, T>
	{
		public Cast(_slider_.SliderI<T> original, Func<T, T> func) : base(original, func)
		{

		}
	}

	
}
