using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var_.typed_
{
 	public  class OvObj<T>
		:nilnul.var_.Typed
		,
		nilnul.VarI3<T>
		

	{

		public OvObj():base(typeof(T)) {
			
		}



		
	}

}
