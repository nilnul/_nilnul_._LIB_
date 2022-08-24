using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str._seeded
{
	[Obsolete()]
	public interface TailI<out T>
	{
		T tail { get; }

	}
}
