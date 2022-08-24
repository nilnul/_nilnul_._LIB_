using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl._seed
{
	

	public abstract class SeedA<T,TTail>:
		Head<T>
		,
		TailI<TTail>

	{

		

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		

		public SeedA(T head, TTail tail):base(head)
		{
			_tail = tail;
		}

		public override string ToString()
		{
			return $"({   head.ToString() + ((_tail is SansI)?"":","+_tail.ToString())   })";
		}
	}


}
