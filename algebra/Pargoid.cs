using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.algebra
{
	/// <summary>
	/// set with an partial op.
	/// </summary>
	public class Pargoid<T,TEq>
		where TEq:IEqualityComparer<T>
	{
		private Set<T,TEq> _set;

		public Set<T,TEq> set
		{
			get { return _set; }
			set { _set = value; }
		}

		/// <summary>
		/// the op doesn't throw exception, but return some T not in set.
		/// If the op throws exception, the exception should be unioed with T, and a new type , as well as subsequently the new Pargoid should be defined.
		/// </summary>
		private Func<T,T,T > _op;

		public Func<T,T,T> op
		{
			get { return _op; }
			set { _op = value; }
		}

	}
}
