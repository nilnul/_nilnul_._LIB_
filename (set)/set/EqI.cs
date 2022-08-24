using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public interface EqI<T>:IEqualityComparer<
		HashSet<T>
	>
	{
	}

	public interface EqI<T, TEq>
		:
		IEqualityComparer<Set1<T, TEq>>
		where TEq:IEqualityComparer<T>,new()
	{

	}
}
