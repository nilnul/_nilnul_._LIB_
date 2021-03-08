using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{


	//[Obsolete()]
	public  interface BeI<T>
	{
		bool be(T obj);
	}
	[Obsolete()]
	public class Be<T> :
		nilnul.Box1<Func<T, bool>>
		,
		BeI<T>
	{
		public Be(Func<T, bool> val) : base(val)
		{
		}

		public bool be(T obj)
		{
			return boxed(obj);
			//throw new NotImplementedException();
		}
	}

	public class Be1<T> :
		nilnul.Box1<Predicate<T>>
		,
		BeI<T>
	{
		public Be1(Predicate<T> val) : base(val)
		{
		}

		public Be1(Func<T,bool> func):this(new Predicate<T>(func))
		{

		}

		public bool be(T obj)
		{
			return boxed(obj);
			//throw new NotImplementedException();
		}
	}

}
