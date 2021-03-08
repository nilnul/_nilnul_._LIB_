using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op.k
{
	/// <summary>
	/// Given T, there are #T of constant functions.
	/// </summary>
	public  class NullaryFunction< T>
		:FunctionI<T>
		
	{
		private T _result;

		public T result
		{
			get { return _result; }
			set { _result = value; }
		}
		

		public NullaryFunction(T result)
		{
			this.result = result;
		}

		public HashSet<object> domain {
			get {
				return new HashSet<object>();
			}
		}


	}
}
