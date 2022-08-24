using System;
using System.Net;

namespace nilnul.op
{
	public partial interface BiOpI<in P1, in P2,out R>
		:BiOpI<P1,P2>,BiOpI<R>
	{

	}
}
