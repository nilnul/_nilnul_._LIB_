using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public interface BeI<T>
		:nilnul.BeI< HashSet<T>>
	{
	}

	public interface BeI<T, TEq>
		:nilnul.BeI<nilnul.Set1<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
	{

	}
}
