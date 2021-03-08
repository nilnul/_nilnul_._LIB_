using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.element.collection.set;
using nilnul;

namespace nilnul.element.collection.set
{
	

	

	/// <summary>
	/// It's still  a set.
	/// 
	/// A+B
	/// </summary>
	public partial class Union
		:SingleSignOpA,
		UnionI
	{


		static private readonly Union _Instance = new Union();
		private Union() { }
		static public Union Instance
		{
			get
			{
				return _Instance;
			}
		}
				

		public override char sign
		{
			get { return '+'; }
		}


		
	}

	
}
