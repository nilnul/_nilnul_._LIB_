using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.to_
{
	public class Enumerable1<T>:
		enumerable.AsEnumerableA<T>
	{
		private StrI1<T> _str;

		public StrI1<T> str
		{
			get { return _str; }
			set { _str = value; }
		}

		public Enumerable1(StrI1<T> str)
		{
			_str = str;
		}

		public override IEnumerator<T> GetEnumerator()
		{
			if (_str is EmptyI)
			{
				yield break;
			}

			else
			{
				var started = (_str as str_.StartedI_tailGeneric<T>);
				yield return started.head;

				foreach (var item in started.tail.ToEnumerable())
				{
					yield return item;
				}
				//yield break;

			}
			//yield break;

			//throw new NotImplementedException();
		}
	}
	static public class EnumerableX
	{
		static public Enumerable1<T> ToEnumerable<T>(this StrI1<T> str) {
			return new Enumerable1<T>(str);
		}

	}


	[Obsolete()]
	public class Enumerable<T>:
		StrA<T>,
		IEnumerable<T>
	{
		private StrI<T> _str;

		public StrI<T> str
		{
			get { return _str; }
			set { _str = value; }
		}

		public Enumerable(StrI<T> str)
		{
			_str = str;
		}

		public override IEnumerator<T> GetEnumerator()
		{
			if (_str is EmptyI)
			{
				yield break;
			}

			else
			{
				yield return (_str as _seeded.SeedI<T>).seed;
				foreach (var item in (_str as _seeded.TailI<StrI<T>>).tail)
				{
					yield return item;
				}
				yield break;

			}
			yield break;

			throw new NotImplementedException();
		}
	}
}
