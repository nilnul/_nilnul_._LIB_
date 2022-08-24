using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var_.handled_.typed_
{
	public class OvObj<T>
	   :

		handled_.Typed
	   ,
	   handled_.TypedI


	{
		public OvObj(Handle val) : base(val, typeof(T))
		{
		}

		static public OvObj<T> Ov<TFro>(OvObj<TFro> ovObj)
			where TFro : T
		{
			return new OvObj<T>(ovObj.handle);
		}
		
	}

}
