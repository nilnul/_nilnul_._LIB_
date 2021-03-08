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

	public partial class SingletonByDefaultNew<YourClass>
		where YourClass:new()
		//where YourClass:class
	{

		static public readonly YourClass Instance = new YourClass();

		//static protected readonly YourClass _Instance= new YourClass();
		//static public YourClass Instance
		//{
		//	get
		//	{
		//		return _Instance;
		//	}
		//}

		
				
	}
}
