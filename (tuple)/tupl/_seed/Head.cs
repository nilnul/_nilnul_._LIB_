using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl._seed
{



	public interface HeadI<T>
	{
		T head { get; }
	}


	public class Head<T>:HeadI<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		public Head(T head)
		{
			_head = head;
		}
	}


}
