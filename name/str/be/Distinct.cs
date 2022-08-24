using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name = nilnul.txt.be.Name.Asserted;

namespace nilnul.name.str.be
{
	static public class _DistinctX
	{
		static public bool BeDistinct(this IEnumerable<Name> names) {

			return nilnul.str.be.DistinctX.IsDistinct_eqDefault<Name,name.Eq>(names);

		}

		static public void AssertDistinct(this IEnumerable<Name> names) {
			 nilnul.Assert1.True(names.BeDistinct());
		}
	}






}
