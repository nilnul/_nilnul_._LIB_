using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.vow_
{
	public class True : 
		
		VowI<bool>
	{

		public void vow(bool obj)
		{
			if (!obj)
			{
				nilnul.vow_.None.Vow( );
			}
 		}

		public void vow(bool obj,string msg)
		{
			if (!obj)
			{
				nilnul.vow_.None.Vow( msg);
			}
 		}

		public void vow<TXpn>(bool obj,TXpn msg)
			where TXpn:Exception//,new()
		{
			if (!obj)
			{
				nilnul.vow_.None.Vow( msg);
			}
 		}






		static public True Singleton
		{
			get
			{
				return nilnul.Singleton1<True>.Instance;
			}
		}


		static public void Vow(bool obj) {
			if (!obj)
			{
				nilnul.vow_.None.Vow( );
			}

		}
		static public void Vow(bool obj,Exception exception) {
			if (!obj)
			{
				nilnul.vow_.None.Vow(exception );
			}

		}

		static public void Vow(bool obj,string exception) {
			Vow(obj,new Exception(exception));

		}


	}
}
