using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.function;

namespace nilnul.func.nullary
{
	/// <summary>
	/// Given T, there are #T of constant functions.
	/// 
	/// </summary>
	/// <remarks>
	/// it's a relation of the following forms:
	/// (  (), T1)
	/// 
	/// or a relatio of the following forms:
	/// ( (), T2).
	/// 
	/// or
	/// ...
	/// 
	/// not, it's different from constant function in that constant function may take parameters. for exmaple a binary constant function is a plane parallet to the x-y plane. a unvary constant function is a line parellet to the x-axis. a nullary constant function is nullary function itself.
	/// 
	/// 
	/// use nullary fucntion can avoid such ambiguity.
	/// 
	/// </remarks>
	public  class Function< T>
		:FunctionI<T>
		
	{
		private T _result;

		public T result
		{
			get { return _result; }
			set { _result = value; }
		}
		

		public Function(T result)
		{
			this.result = result;
		}

		public nilnul.collection.set.EmptySet domain {
			get {
				return nilnul.collection.set.EmptySet.Instance;
			}
		}


	}
}
