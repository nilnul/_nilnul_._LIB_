using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;
//using nilnul;

namespace nilnul.collection.set
{
	public abstract class SetBinaryOpExprA
		: BinaryOpExprA<SetI, SetI, SetI, SetI,SetI>, SetBinaryOpExprI
	{
		//public abstract BinaryOp_I<Set_I, Set_I, Set_I> op
		//{
		//    get;
		//    set;
		//}
		public SetBinaryOpExprA(SetI a,SetI b):base(a,b)
		{

		}

		


		#region Set_I Members

		public bool? hasElement(object element)
		{
			throw new NotImplementedException();
		}

		#endregion
	
	
}


}
