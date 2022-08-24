using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var_.handled_.ovObj_
{
	

	/// <summary>
	/// convert var from one type to another
	/// </summary>
	/// <typeparam name="TFro"></typeparam>
	/// <typeparam name="TTo"></typeparam>
	public class Box<TFro, TTo>
		:
		nilnul.Box1<handled_.OvObjI<TFro>>
		
		,
		var_.handled_.OvObjI<TTo>

		where TFro : TTo
	{
		public Box(OvObjI<TFro> val) : base(val)
		{
		}




		public Handle handle => boxed.handle;
	}
}
