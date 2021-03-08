using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name = nilnul.txt.be.Name.Asserted;

namespace nilnul.name.str.be_
{
	[Obsolete()]
	static public class _NotContainX
	{


		static public bool NotContain(this IEnumerable< Name> names, Name name) {


			return nilnul.obj.str.be_.NotContainX.NotContain_eqDefault< Name, nilnul.obj.name.Eq>(names, name);


		}

		static public bool Contain(this IEnumerable<Name> names, Name name) {


			return nilnul.str.ContainX.Contain_eqDefault< Name, nilnul.obj.name.Eq>(names, name);


		}


		static public bool NotContain(this IEnumerable<Name> names, string name) {


			return ! names.Select(x=>x.avowed).Contains(name);


		}

		static public bool Contain(this IEnumerable< Name> names, string name) {


			return  names.Select(x=>x.avowed).Contains(name);


		}


	}
}
