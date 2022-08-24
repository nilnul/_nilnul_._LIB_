using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.tupl._seed
{
	public interface TailI<TTail>
	{
		TTail tail { get; }
	}
}
