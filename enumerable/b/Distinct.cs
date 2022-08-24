using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.enumerable.b
{
	public  class Distinct_eqDefault<TElement, TEq>
		: Distinct<TElement,TEq>
		
		where TEq : IEqualityComparer<TElement>,new()
	{

		static public Distinct_eqDefault<TElement, TEq> Singleton = SingletonByDefault<Distinct_eqDefault<TElement, TEq>>.Instance;

		public Distinct_eqDefault():base(SingletonByDefault<TEq>.Instance)
		{

		}

		public class Asserted : nilnul.Asserted<IEnumerable<TElement>, Distinct_eqDefault<TElement,TEq>>
		{

			public Asserted(IEnumerable<TElement> val) : base(val)
			{

			}
		}


	}
	[Obsolete("nilnul.obj", false)]

	public class Distinct_eqDefault<TElement, TEq,TEnumerable>
		: Distinct<TElement,TEq,TEnumerable>
		
		where TEq : IEqualityComparer<TElement>,new()
		where TEnumerable:IEnumerable<TElement>
	{

		static public Distinct_eqDefault<TElement, TEq,TEnumerable> Singleton = SingletonByDefault<Distinct_eqDefault<TElement, TEq,TEnumerable>>.Instance;

		public Distinct_eqDefault():base(SingletonByDefault<TEq>.Instance)
		{

		}

		public class Asserted : nilnul.Asserted<TEnumerable, Distinct_eqDefault<TElement,TEq,TEnumerable>>
		{

			public Asserted(TEnumerable val) : base(val)
			{

			}


		}


	}

	public  class Distinct<TElement,TEq>
		:BeI<IEnumerable<TElement>>
		where TEq:IEqualityComparer<TElement>
	{

		[Obsolete("",true)]
		static public bool Be(IEnumerable<TElement> val) {

			return (val.Count()>0);
		
		}

			[Obsolete("",true)]
	static public bool Eval(IEnumerable<TElement> val, TElement eval) {

			return (val.Count()>0);
		
		}

		private TEq _eq;

		public TEq eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct(TEq eq)
		{
			_eq = eq;

		}



		public bool _be(IEnumerable<TElement> s_distinct, TElement a) {
			return s_distinct.All(
				x=> !eq.Equals(x, a)	
			);
		}

		public bool be(IEnumerable<TElement> obj)
		{


			return obj.Count()==0 || be(obj.Skip(1)) && _be(obj.Skip(1), obj.First());

			throw new NotImplementedException();
		}




	}

	[Obsolete("nilnul.obj",false)]
	public  class Distinct<TElement,TEq,TEnumerable>
		:BeI<TEnumerable>
		where TEq:IEqualityComparer<TElement>
		where TEnumerable:IEnumerable<TElement>
	{
		[Obsolete("",true)]
		static public bool Be(TEnumerable val) {

			return (val.Count()>0);
		
		}
		[Obsolete("",true)]

		static public bool Eval(TEnumerable val, TElement eval) {

			return (val.Count()>0);
		
		}

		private TEq _eq;

		public TEq eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct(TEq eq)
		{
			_eq = eq;

		}



		public bool _be(IEnumerable<TElement> s_distinct, TElement a) {
			return s_distinct.All(
				x=> !eq.Equals(x, a)	
			);
		}

		public bool be(IEnumerable<TElement> obj)
		{

			

			return obj.Count()==0 || be(obj.Skip(1)) && _be(obj.Skip(1), obj.First());

			//throw new NotImplementedException();
		}
		public bool be(TEnumerable obj)
		{

			return be(obj as IEnumerable<TElement>);
		}



	}



}
