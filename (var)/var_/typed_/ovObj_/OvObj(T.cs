using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var_.typed_
{
 

	/// <summary>
	/// convert var from one type to another
	/// </summary>
	/// <typeparam name="TFro"></typeparam>
	/// <typeparam name="TTo"></typeparam>
	public class Box<TFro, TTo>
		: nilnul.Box1<VarI3<TFro>>
		,
		nilnul.VarI3<TTo>
		,
		var_.HandledI

		where TFro : TTo
	{
		public Box(VarI3<TFro> val) : base(val)
		{
		}

		public Handle handle => {
			var handle = this;
			return handle;
		};
	}
}
