using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete("nilnul.obj_.")]
	public class Singleton1<T>
		where T:new()
		//where YourClass:class
	{



		static private   T _Instance= new T();
		static public T Instance
		{
			get
			{
				return _Instance;
				// _Instance = _Instance ?? new YourClass();// some one online suggested this, but "error: ?? cannot be appplied on YourClass and YourClass"
				//return _Instance;
			}
		}

		/// <summary>
		/// due to env(such as configuration) change
		/// </summary>
		static public void Reset() {
			_Instance = new T();
		}
		private Singleton1() {
		}
				
	}
}
