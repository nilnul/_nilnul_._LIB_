using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul
{
	[Obsolete("nilnul.str")]
	static public partial class X
	{
		static public IEnumerable<object> ToTyped(IEnumerable list)
		{

			foreach (var item in list)
			{
				yield return item;
			}

		}
		static public IEnumerable<object> ToTypedAsObject(IEnumerable list)
		{

			foreach (var item in list)
			{
				yield return item;
			}

		}
	}
}
