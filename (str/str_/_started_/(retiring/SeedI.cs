using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str._seeded
{
	[Obsolete()]
	public interface SeedI< out T> 
	{
		T seed { get; }


	}

}
