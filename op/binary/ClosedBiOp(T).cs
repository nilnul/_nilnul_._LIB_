using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public partial class ClosedBiOp_str<T>
		:ClosedBiOpI<T>
	{
		string name;

		public Func<T, T,T> func
		{
			get;
			set;
		}
		public ClosedBiOp_str(Func<T,T,T> func)
		{
			this.func = func;
		}

		public ClosedBiOp_str(Func<T, T, T> func,string name)
		{
			this.func = func;
			this.name = name;
		}

		public override string ToString()
		{
			return name;
		}
	}
}
