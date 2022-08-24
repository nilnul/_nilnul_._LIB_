using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface StrI
	{
	}


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Obsolete()]
	public interface StrI< out T> : StrI, IEnumerable<T> {



	}

	/// <summary>
	/// umbrella for two subtype: Sans, Sperm.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	//[Obsolete("nilnul.obj")]
	public interface StrI1< out T> : StrI {



	}






	public abstract class StrA<T> :  StrI<T>, IEnumerable<T>
	{
		public abstract IEnumerator<T> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}


}
