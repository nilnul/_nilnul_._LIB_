using nilnul.str._seeded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str_._started_;

namespace nilnul.str_
{
	public interface StartedI:StrI { }

	public interface StartedI<out T>
		:
		_started_.HeadI<T>
		,
		StrI1<T>
	{


	}


	public interface StartedI<out T, out TTail>:
		StartedI<T>
		,
		_started_.TailI<TTail>
	{
	}


	public interface StartedI_tailGeneric<out T>:StartedI<T,StrI1<T>>
	{

	}
	public class StartedA<T, TTail>
		: StartedI<T, TTail>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			private set { _head = value; }
		}

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
	
		public StartedA(T head, TTail tail)
		{
			_head = head;
			_tail = tail;
		}
	}

	public class Started<T,TTail>:StartedA<T,TTail>
		where TTail:StrI1<T>
	{
		public Started(T seed, TTail tail):base(seed,tail)
		{

		}
	}

	public class Started_tailStr<T>
		: Started<T, StrI1<T>>
	{
		public Started_tailStr(T seed, StrI1<T> tail) : base(seed, tail)
		{
		}
	}
}
