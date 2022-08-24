using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.be
{
	

	public partial class Assert<T>
	:

	Assert<T, BeI<T>>


	{


		public Assert(BeI<T> b)
			: base(b)
		{

		}


	}

	public partial class Assert_TbeDefault<T, TBe>
	:

	Assert<T, TBe>


	where TBe : BeI<T>, new()

	{

		static public Assert_TbeDefault<T, TBe> Singleton = SingletonByDefault<Assert_TbeDefault<T, TBe>>.Instance;


		public Assert_TbeDefault()
			: base(SingletonByDefault<TBe>.Instance)
		{

		}

		static public void Assert(T obj) {
			Singleton.assert(obj);
		}


	}



	public partial class Assert<T, TB>
: AssertI<T>
where TB : BeI<T>
	{


		private TB _b;

		public TB b
		{
			get { return _b; }
			set { _b = value; }
		}


		public Assert(TB b)
		{
			_b = b;
		}

		public void assert(T obj)
		{
			Assert1.True(
				_b.be(obj)
			);
			return;

			throw new NotImplementedException();
		}
	}




}
