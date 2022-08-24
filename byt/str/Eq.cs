using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.byt.str
{
	public class Eq:_generic.str.Eq<byte>,IEqualityComparer<IEnumerable<byte>>
	{
		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;
		static public bool Eval(byte[] x, byte[] y) {
			return Singleton.Equals(x, y);
		}
	}
}
