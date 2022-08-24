using nilnul.str._seeded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public interface SeededI:StrI { }

	public interface SeededI<out T>:SeedI<T>,StrI1<T> {


	}


	public interface SeededI<out T, out TTail>:SeededI<T>,_seeded.TailI<TTail>

	{

	}


	public interface SeededI_forGeneric<out T>:SeededI<T,StrI1<T>>
	{

	}
	public class SeededA<T, TTail> : SeededI<T, TTail>
	{
		private T _seed;

		public T seed
		{
			get { return _seed; }
			private set { _seed = value; }
		}

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
	
		public SeededA(T head, TTail tail)
		{
			_seed = seed;
			_tail = tail;
		}
	}

	public class Seeded<T,TTail>:SeededA<T,TTail>
		where TTail:StrI<T>
	{
		public Seeded(T seed, TTail tail):base(seed,tail)
		{

		}


	}

	public class Seeded1<T,TTail>:SeededA<T,TTail>
		where TTail:StrI1<T>
	{
		public Seeded1(T seed, TTail tail):base(seed,tail)
		{

		}


	}

	[Obsolete()]

	public class Seeded<T> : StrA<T>
	{

		private T _start;

		public T start
		{
			get { return _start; }
			set { _start = value; }
		}

		private StrI<T> _tail;

		public StrI<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}


		public Seeded(T start, StrA<T> tail)
		{
			_start = start;
			_tail = tail;

		}

		public Seeded(T start, StrI<T> tail)
		{
			_start = start;
			_tail = tail;

		}

		public override IEnumerator<T> GetEnumerator()
		{
			yield return _start;
			foreach (var item in _tail)
			{
				yield return item;
			}
			yield break;

			throw new NotImplementedException();
		}
	}
}
