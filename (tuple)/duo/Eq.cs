using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.duo
{


	public class Eq_elementEqDefault<T,TEq>
		: Eq<T,TEq>
		where TEq : IEqualityComparer<T>,new()
	{
		public Eq_elementEqDefault()
			:base(SingletonByDefault<TEq>.Instance)
		{
		}
	}



	public class Eq<T,TEq>
		: Eq<T,TEq,Tuple<T,T>>
		where TEq : IEqualityComparer<T>
	{
		public Eq(TEq elementEq)
			:base(elementEq)
		{
		}
	}





	public class Eq_elementEqDefault<T,TEq,TDuo>
		: Eq<T,TEq,TDuo>
		where TEq : IEqualityComparer<T>,new()
		where TDuo : Duo<T>
	{
		public Eq_elementEqDefault()
			:base(SingletonByDefault<TEq>.Instance)
		{
		}
	}

	public class Eq<T,TEq,TDuo>

		: Eq<T,T,TEq,TEq,TDuo>
		where TEq : IEqualityComparer<T>
		where TDuo : Tuple<T,T>

	{
		public Eq(TEq domainEq):base(domainEq,domainEq)
		{

		}



	}

	public class Eq_elementEqDefault<T, T1, TEq, T1Eq, TDuo>

		: Eq<T,T1,TEq,T1Eq,TDuo>
		where TEq : IEqualityComparer<T>,new()
		where T1Eq : IEqualityComparer<T1>,new()
		where TDuo : Tuple<T, T1>
	{

		public Eq_elementEqDefault()
			
			:base(SingletonByDefault<TEq>.Instance, SingletonByDefault<T1Eq>.Instance)
		{



		}
	}


	public class Eq<T, T1, TEq, T1Eq, TDuo>

		: IEqualityComparer<TDuo>
		where TEq : IEqualityComparer<T>
		where T1Eq : IEqualityComparer<T1>
		where TDuo : Tuple<T, T1>
	{

		private TEq _domainEq;

		public TEq domainEq
		{
			get { return _domainEq; }
			set { _domainEq = value; }
		}

		private T1Eq _rangeEq;

		public T1Eq rangeEq
		{
			get { return _rangeEq; }
			set { _rangeEq = value; }
		}

		

		public Eq(TEq domainEq, T1Eq rangeEq)
		{
			_domainEq = domainEq;
			_rangeEq = rangeEq;

		}
		public bool Equals(TDuo x, TDuo y)
		{

			return _domainEq.Equals(x.Item1, y.Item1) && _rangeEq.Equals(x.Item2, y.Item2);

			throw new NotImplementedException();
		}

		public int GetHashCode(TDuo obj)
		{
			return _domainEq.GetHashCode(obj.Item1) ^ _rangeEq.GetHashCode(obj.Item2) ;

			throw new NotImplementedException();
		}
	}
}
