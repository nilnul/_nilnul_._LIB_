using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl._seeded
{


	[Obsolete("Head")]
	public interface SeedI<T>
	{
		T seed { get; }
	}


	public interface SeedOfObjectI:SeedI<object> {



	}

}
