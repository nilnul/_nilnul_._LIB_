using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.tupl._seed
{
	public interface SeedI<THead,TTail>:_seed.HeadI<THead>, _seed.TailI<TTail>
	{
	}

	public class Seed<THead, TTail> : SeedI<THead, TTail>
	{

		private THead _head;
		public THead head
		{
			get
			{
				return _head;
				throw new NotImplementedException();
			}
		}

		private TTail _tail;
		public TTail tail
		{
			get
			{
				return _tail;
				throw new NotImplementedException();
			}
		}

		public Seed(THead head, TTail tail)
		{
			_head = head;
			_tail = tail;
		}

	}



}
