using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._stream
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete(nameof(_stream_.NextI<T>))]
	public interface NextI<out T> {
		T next();

	}

	public interface StreamI {

	}

	public interface StreamI<T> : NextI<T>,StreamI,_stream_.NextI<T> { }

	[Obsolete()]
	public abstract class StreamA<T> : StreamI<T>
		, IEnumerable<T>

	{
		//public abstract IEnumerator<T> GetEnumerator();


		public IEnumerator<T> GetEnumerator() {
			while (true)
			{
				yield return next();
			}
		}


		public abstract T next();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


}
