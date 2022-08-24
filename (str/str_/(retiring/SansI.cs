using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	[Obsolete()]
	public interface SansI:StrI
	{
	}
	[Obsolete()]
	public class Sans:SansI
	{
		static public readonly Sans Singleton = SingletonByDefault<Sans>.Instance;
	}

	[Obsolete()]
	public class Sans<T>:Sans,StrI1<T>
	{
		static public readonly Sans<T> Singleton = SingletonByDefault<Sans<T>>.Instance;


	}


}
