using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl._seed
{



	public interface TailI<out T>
	{
		T tail { get; }
	}

	public class Tail<T>:TailI<T>
	{
		private T _tail;

		public T tail
		{
			get { return _tail; }
			set { _tail = value; }
		}


		public Tail(T tail)
		{
			_tail = tail;
		}
	}


	public interface TailOfTuplI:TailI<TuplI>
	{
	}

	

}
