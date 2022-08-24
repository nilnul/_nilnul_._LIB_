using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._slider_
{
	[Obsolete("nilnul.obj.")]
	public interface SliderI<T>
		:MoveNextI, CurrentI<T>
	{
	}
}
