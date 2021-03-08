using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.enumerable.distinct
{
	public class Union<T,TEq >
		where TEq:IEqualityComparer<T>,new()
		//where TEnumerable:IEqualityComparer<T>

	{
		private TEq _eq;

		public TEq eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Union(TEq eq)
		{
			_eq = eq;
		}


		public b.Distinct_eqDefault<T, TEq>.Asserted eval(b.Distinct_eqDefault<T,TEq>.Asserted a, b.Distinct_eqDefault<T, TEq>.Asserted b) {

			return new enumerable.b.Distinct_eqDefault<T, TEq>.Asserted( a.val.Union(b.val, _eq));
		}

	}
}
