using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	static public class IEnumerable_ToStrX
	{
		static public string ToStr<T>(this IEnumerable<T> list,string seperator) {
			bool hasElement=false;
			return list.Aggregate(
				"", 
				(w, c) =>{
					if (hasElement == false) { hasElement = true; return w + c;  }
					else{
						return w+seperator+c;
					}
				}
				//,r =>  r.Length>=seperator.Length?r.Remove(r.Length - seperator.Length):r
			);
			
			
		}
		static public string ToStr<T>(this IEnumerable<T> list)
		{
			return list.ToStr(",");
		}
	

	
	}
}
