using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_
{

	public interface SansI:StrI
	{

	}

	public class Sans:SansI
	{
		static public readonly Sans Singleton = SingletonByDefault<Sans>.Instance;
	}


	public class Sans<T>:Sans,StrI1<T>
	{
		static public readonly Sans<T> Singleton = SingletonByDefault<Sans<T>>.Instance;


	}


}
