using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var_
{
	public interface HandledI:_handled_.HandleI
	{
	}

	public class Handled :
		nilnul.Box1<
		_handled.Handle>,

		HandledI
	{
		public Handled(Handle val) : base(val)
		{
		}

		public Handle handle => boxed;
	}

}
