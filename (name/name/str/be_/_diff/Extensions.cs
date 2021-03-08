using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace nilnul.obj.name.str.be_._diff
{
	[Obsolete()]
	static public class _Extensions
	{
		static public bool BeDistinct(this IEnumerable<Name> names) {

			return nilnul.str.be.DistinctX.IsDistinct_eqDefault<Name,name.Eq>(names);

		}

		static public void AssertDistinct(this IEnumerable<Name> names) {
			 nilnul.Assert.True(names.BeDistinct());
		}
	}






}
