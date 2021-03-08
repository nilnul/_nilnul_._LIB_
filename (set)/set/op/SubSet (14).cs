using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element.collection.set.relation
{
	/// <summary>
	/// If every element in A is in B, we say that A is subset of B.
	/// If every element in A is in B, and B is not subset of A, we say that A is a properSubSet of B.
	/// </summary>
	public partial class SubSet
		:ISubSet
		
	{

		static private readonly SubSet _Instance = new SubSet();
		static public SubSet Instance
		{
			get
			{
				return _Instance;
			}
		}
		private SubSet()
		{
		}
				
		

	}
}
