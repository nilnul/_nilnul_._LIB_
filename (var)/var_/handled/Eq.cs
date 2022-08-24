using nilnul.var_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.handled.eq_
{

	public class Handle : IEqualityComparer<nilnul.var_.HandledI>
	{
		


		static public Handle Singleton
		{
			get
			{
				return nilnul.Singleton1<Handle>.Instance;
			}
		}

		

		public bool Equals(HandledI x, HandledI y)
		{
			return x.handle == y.handle;
		//	throw new NotImplementedException();
		}

		

		public int GetHashCode(HandledI obj)
		{
			return obj.handle.GetHashCode();
			//throw new NotImplementedException();
		}
	}

}
