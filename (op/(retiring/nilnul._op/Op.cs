using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._op
{


	public interface OpI_RFirst<out R, in P> : ResultI<R>, PI<P> {

	}
	public interface OpI_RFirst<out R, in P, in P1> : ResultI<R>, PI<P,P1> {

	}
	public interface OpI<in P, in P1, in P2, out R> : ResultI<R>, PI<P,P1> {

	}

	
	public interface OpI<in P, in P1, out R> : ResultI<R>, PI<P,P1> {

	}

	public interface PI<in T, in T1, in T2>:PI<T,T1>, P2I<T> { }


	public interface PI<in T, in T1>:PI<T>, P1I<T> { }
	public interface P2I<in T> {}

	/// <summary>
	/// the p1 is of type T
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public interface P1I<in T> {}

	/// <summary>
	/// the p is of type T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface PI<in T> {


	}

	/// <summary>
	/// result is of type T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ResultI<out T> {

	}
	public interface Generic<out T>
		:OpI_generic
		,ResultI<T>

	{

	}


	public interface OpI_generic {


	}
}
