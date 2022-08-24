using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl._seeded
{



	public interface TailI<out T>
	{
		T tail { get; }
	}


	public interface TailOfTuplI:TailI<TuplI>
	{
	}

	

}
