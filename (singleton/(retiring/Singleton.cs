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
	[Obsolete("nilnul.obj_.")]
	public  class Singleton<YourClass>
		//where YourClass:new()
		//where YourClass:class
	{

		static protected  YourClass _Instance;//= new YourClass();
		static public YourClass Instance
		{
			get
			{
				return _Instance;
			}
		}

		static Singleton() {
			

			//var c=typeof(YourClass).TypeInitializer;
			//c.Invoke(System.Reflection.BindingFlags.SetProperty,(new object[0]);

		//	var d=Activator.CreateInstance(typeof(YourClass));

			///note: type is initialized onlyf before its static member is invoked or an instance is constructed.
			/// var f=Activator.CreateInstance<YourClass>();	//this is exception
			/// YourClass.Intialize();	//this is ok.
			System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(YourClass).TypeHandle);


		
		}
		protected Singleton()
		{
		}
				
	}
}
