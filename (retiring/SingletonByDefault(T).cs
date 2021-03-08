using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	/// 
	[Obsolete("nilnul.obj")]
	public  class SingletonByDefault<YourClass>
		where YourClass:new()
		//where YourClass:class
	{

		static protected YourClass _Instance= new YourClass();
		static public YourClass Instance
		{
			get
			{
				return _Instance;
			}
		}


		static private Lazy<YourClass> _Lazy = new Lazy<YourClass>();
		static public YourClass Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		static SingletonByDefault() {
			//_Instance = new YourClass();
			/// _Instance may be null if the type is not initialized before property is accessed.
		}

		protected SingletonByDefault() {
		
		}
				
	}
}
