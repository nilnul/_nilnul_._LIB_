using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.duo.be
{
	static public class EndWithX
	{
		static public bool EndWith<T>(Tuple<T,T> duo, T node, IEqualityComparer<T> eq) {
			return eq.Equals(duo.Item2, node);
		}




		static public bool EndWith<T,TEq>(this Tuple<T,T> duo, T node)
			where TEq:IEqualityComparer<T>,new()
		{
			return EndWith(duo,node,SingletonByDefault<TEq>.Instance);
		}




		static public bool EndWith<T>(Duo<T> duo, T node, IEqualityComparer<T> eq) {
			return EndWith(duo as Tuple<T,T>, node, eq);
		}


	}
}
