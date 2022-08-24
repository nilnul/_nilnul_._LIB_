using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.be_
{
	static public class _DistinctX
	{

		static public bool Be<T>(this IEnumerable<T> str, IEqualityComparer<T> eq)

		{
			if (nilnul.seq.be_._NoneX1.Be(str))
			{
				return true;
			}

			var tail = enumable_.started._TailX.Tail(str);

			return Be(tail, eq)
				&&
				be_._NotContainX.NotContain(tail, str.First(), eq);

		}



		static public bool Be<T,TEq>
		
			(this IEnumerable<T> vars)
			where TEq :IEqualityComparer<T>,new()


		{
			return Be(vars, nilnul.Singleton1<TEq>.Instance);


		}




	}

	public class Distinct<T> : 
		nilnul.Box1<IEqualityComparer<T>>
		,
		BeI1<T>
	{
		public Distinct(IEqualityComparer<T> eq):base(eq)
		{

		}
		public bool be(SeqI<T> obj)
		{
			return _DistinctX.Be(obj,this.boxed);
			//throw new NotImplementedException();
		}
	}

	public class Distinct<T, TEq> : Distinct<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct() : base(nilnul.Singleton1<TEq>.Instance)
		{
		}

		static public Distinct<T, TEq> Singleton
		{
			get
			{
				return nilnul.Singleton1<Distinct<T, TEq>>.Instance;
			}
		}

	}
}
