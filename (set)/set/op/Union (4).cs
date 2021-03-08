using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.linearAlgebra;

using nilnul.collection.set;

namespace nilnul.collection.set.operation
{
	public interface IUnion:ISet { 

	}

	/// <summary>
	/// used to union strong-typed sets.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IUnion<T> :  ISet<T>
		where T:IEquatable<T>
	{ 

	}

	/// <summary>
	/// It's still  a set.
	/// 
	/// A+B
	/// </summary>
	public class Union:Set,IUnion
	{
		public Set[] sets;

		public Union(params Set[] sets) {
			this.sets = sets;
		}

		public override string ToString()
		{
			return "+("+ sets.toString() +")";
		}
	}

	public class Union<T> :Set<T>, IUnion<T> 
		where T:IEquatable<T>
	{
		private IList<Set<T>> _operands;

		//public Union(IList<Set<T>> operands) {
		//    _operands = operands;
		//}

		public Union(params Set<T>[] operands) {
			_operands = operands.ToList();
		}
		public IList<Set<T>> operands {
			get {
				return _operands;
			}
		}

		public override string ToString()
		{
			return "+(" + operands.ToArray().toString() + ")";
		}

		
	}
}
