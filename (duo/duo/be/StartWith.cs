using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.duo.be
{
	static public class StartWithX
	{
		static public bool StartWith<T>(Duo<T> duo, T node, IEqualityComparer<T> eq) {
			return eq.Equals(duo.Item1, node);
		}
		static public bool Eval<T>(Tuple<T,T> duo, T node, IEqualityComparer<T> eq) {
			return eq.Equals(duo.Item1, node);
		}

		static public bool StartWith<T,TEq>
			(this Tuple<T,T> duo, T node)
			where TEq:IEqualityComparer<T>,new()
		{
			return Eval(duo,node,SingletonByDefault<TEq>.Instance);
		}


	}
}
