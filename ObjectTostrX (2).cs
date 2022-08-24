using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul
{
	static public partial class ToStrX
	{
		static public string ToStr(this object o) {
			if (o is IEnumerable)
			{
				//return nilnul.element.collection.CollectionTostrX.Tostr((IEnumerable)o);
				return CollectionTostrX.Tostr(o as IEnumerable);
			}
			else
			{
				return o.ToString();
			}
		
		}
	}
}
