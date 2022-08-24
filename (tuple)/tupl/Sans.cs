using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl
{
	public interface SansI : TuplI { }

	public class Sans:SansI
	{

		public override string ToString()
		{
			return "()";
		}
	}

	public class Sans<T>:Sans
	{

	}


}
