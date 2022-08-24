using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.type
{
	/// <summary>
	/// t is the store type. func is the constraint it's satisfied.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Element<T>
	{
		T val;
		Func<T, bool> func;

	}
}
