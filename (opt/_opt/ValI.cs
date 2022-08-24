using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._opt
{
	public interface ValI { }

	public interface ValI<out T>:ValI
	{
	}
}
