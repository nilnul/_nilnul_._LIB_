using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._stream_
{

	/// <summary>
	/// the aspect of stream
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	//[Obsolete("nilnul.obj")]
	public interface NextI<out T> {
		T next();

	}

	


}
