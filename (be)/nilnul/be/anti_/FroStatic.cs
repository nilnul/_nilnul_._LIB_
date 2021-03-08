using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.be.anti_
{
	[Obsolete("nilnul.obj")]
	public class FroStatic<T, TBe> :

		nilnul.be.Be_froAntonymBe<T, TBe>

		where TBe : nilnul.BeI<T>, new()
	{
		public FroStatic(TBe be) : base(be)
		{

		}
	}
}
