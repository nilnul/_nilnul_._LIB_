using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.func
{
	static public class _TryX
	{
	
			public static T Try<T>(this Func<T> construct)
			//where T : class
			{
				try
				{
					return construct();
				}
				catch
				{
					return default(T);
				}
			}
		
	}
}
