using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.be
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for inheritators, the vow of be shall be placed after the namespace segment of "be", for in this way, it illustrates the fact that "vow" is constrcuted on "b", which is different from other "vow" that may be unfounded on "be", but, for examples has its own implementation logic.
	/// </remarks>
	public class Vow<T>
		:nilnul.VowI<T>
	{
		private nilnul.BeI<T> _be;

		public nilnul.BeI<T> be
		{
			get { return _be; }
			set { _be = value; }
		}


		public Vow(nilnul.BeI<T> be)
		{
			_be = be;
		}

		public void vow(T obj)
		{

			nilnul.vow_.True.Vow( _be.be(obj));
			//throw new NotImplementedException();
		}
	}

	

	public class Vow<T,TBe> : Vow<T>
		where TBe : nilnul.BeI<T>, new()
	{
		public Vow( ) : base(nilnul.Singleton1<TBe>.Instance)
		{
		}

		public Vow(BeI<T> be) : base(be)
		{
		}

		static public Vow<T,TBe> Singleton
		{
			get
			{
				return nilnul.Singleton1<Vow<T,TBe>>.Instance;
			}
		}

	}



}
