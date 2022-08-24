using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var_.handled_
{
	public interface OvObjI<T>
		:HandledI

	{

	}
	public class OvObj<T>
	   : nilnul.var_.Handled
	   ,
	   OvObjI<T>
	   //,
	   //nilnul.VarI3<T>

	{
		protected OvObj(Handle val) : base(val)
		{
		}
		public OvObj():base(new Handle())
		{
		}

		static public OvObj<T> Ov<TFro>(OvObj<TFro> ovObj)
			where TFro : T
		{
			return new OvObj<T>(ovObj.handle);
		}
	}


}
