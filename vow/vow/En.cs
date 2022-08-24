using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.vow
{
	/// <summary>
	/// vowed objects.'cuz vow is generally derived from be, so vowed is infact been. we get "en" from been; and en is different from but mnemorically related to "ed" in op-ed objects.
	/// </summary>


	public class En<T>
		:
		EnA<T>
		
	{
		


		public En(  VowI<T> vow, T val)
			:base(val)
		{
			vow.vow(val);

		}
	}

	


	public class En<T, TVow>
		: En<T>
		where TVow : nilnul.VowI<T>, new()
	{
		public En(T val) : base( nilnul.Singleton1<TVow>.Instance, val)
		{
		}

		static public implicit operator T(En<T, TVow> en) {
			return en.en;
		}
	}


}
