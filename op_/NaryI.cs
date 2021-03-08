using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op_
{
	public interface NaryI<out TResult>
	{
		TResult op();
	}

	public class Nary<TResult> : NaryI<TResult>
	{
		private TResult _ret;

		public TResult ret
		{
			get { return _ret; }
			set { _ret = value; }
		}

		public Nary(TResult ret)
		{
			_ret = ret;
		}

		public TResult op()
		{
			return _ret;
			//throw new NotImplementedException();
		}
	}

}
