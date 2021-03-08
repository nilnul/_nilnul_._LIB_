using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element.collection.set
{
	/// <summary>
	/// the set of all subsets of the given set.
	/// </summary>
	public class PowerSetExpr
		:SetI, PowerSetExprI
	{
		public SetI set;
		public PowerSetExpr(SetI set) {
			this.set = set;
		}

		//public override UInt_I order {
		//    get {
		//        return 2 ^ set.Order();
		//    }
		//}

		public override string ToString()
		{
			return "2^"+set;
		}


		#region Set_I Members

		public bool? hasElement(object element)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
