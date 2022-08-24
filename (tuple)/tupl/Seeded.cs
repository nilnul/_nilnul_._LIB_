using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl
{
	public interface SeededI
		:TuplI
	{


	}

	public class Seeded<T,TTail>:
		SeededI
		,
		_seeded.SeedOfObjectI

		where TTail:TuplI
	{

		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public object seed
		{
			get
			{
				return _head;
				throw new NotImplementedException();
			}
		}

		public Seeded(T head, TTail tail)
		{
			_head = head;
			_tail = tail;
		}
	}


}
