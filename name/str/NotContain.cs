using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name = nilnul.txt.be.Name.Asserted;

namespace nilnul.name.str
{
	static public class _NotContainX
	{


		static public bool NotContain(this IEnumerable<txt.be.Name.Asserted> names, Name name) {


			return nilnul.str.NotContainX.NotContain_eqDefault<nilnul.txt.be.Name.Asserted, nilnul.name.Eq>(names, name);


		}

		static public bool Contain(this IEnumerable<txt.be.Name.Asserted> names, Name name) {


			return nilnul.str.ContainX.Contain_eqDefault<nilnul.txt.be.Name.Asserted, nilnul.name.Eq>(names, name);


		}


		static public bool NotContain(this IEnumerable<txt.be.Name.Asserted> names, string name) {


			return ! names.Select(x=>x.val).Contains(name);


		}

		static public bool Contain(this IEnumerable<txt.be.Name.Asserted> names, string name) {


			return  names.Select(x=>x.val).Contains(name);


		}


	}
}
