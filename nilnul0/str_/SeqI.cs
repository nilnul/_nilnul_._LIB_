using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_
{
	public interface SeqI<T>:nilnul.StrI2<T>,IEnumerable<T>
	{

	}

	public class Seq<T> :
		nilnul.Box1<IEnumerable<T>>,

		nilnul.str_.SeqI<T>
	{
		public Seq(IEnumerable<T> val) : base(val)
		{
		}
		public Seq():base(new T[0])
		{

		}

		public IEnumerator<T> GetEnumerator()
		{
			return boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}

}
