using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{
	public partial class Be_froAntonymBe<T, TBe>
		:

		BeI<T>

		where TBe : BeI<T>

	{
		private TBe _be;

		public TBe beField
		{
			get { return _be; }
			set { _be = value; }
		}


		public Be_froAntonymBe(TBe be)
		{
			_be = be;

		}
		public bool be(T obj)
		{
			return _be.be(obj);

			throw new NotImplementedException();
		}
	}
}
