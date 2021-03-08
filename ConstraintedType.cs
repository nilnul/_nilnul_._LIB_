using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// a type satisfying some constraints.
	/// </summary>
	/// <typeparam name="T">
	/// the premise type, where the data is stored.
	/// </typeparam>
	public partial class ConstraintedType<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		private Func<T,bool>[] _constraints;

		public Func<T, bool>[] constraints {
			get {
				return _constraints;
			}
			set {
				_constraints = value;
			}
		}


		public ConstraintedType(T val,Func<T,bool>[] constraints)
		{
			this.val = val;
			this.constraints = constraints;
		}
					
		
	}
}
