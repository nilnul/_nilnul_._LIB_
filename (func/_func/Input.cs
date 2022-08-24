using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._func
{
	public interface InputI<out TInput>
	{
		TInput input { get; }
	}

	public class Input<TInput> : InputI<TInput>
	{
		private TInput _input;
		public TInput input
		{
			get
			{
				return _input;
				throw new NotImplementedException();
			}
		}

		public Input(TInput input)
		{
			_input = input;
		}
	}

	

	public interface InputI_Tupl<TInput>
		:InputI<TInput>

		where TInput :var.TuplI
	{

	}


}
