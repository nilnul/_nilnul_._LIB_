using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public interface VowI<T,TEq>
		: nilnul.VowI< nilnul.Set1<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
		
	{
	}
}
