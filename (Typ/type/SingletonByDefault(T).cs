using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.type
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	public partial class SingletonByDefault<YourClass>
		where YourClass:new()
		//where YourClass:class
	{

		static protected  YourClass _Instance= new YourClass();
		static public YourClass Instance
		{
			get
			{
				return _Instance;
			}
		}

		protected SingletonByDefault() {
		
		}
				
	}
}
