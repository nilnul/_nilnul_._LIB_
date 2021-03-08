using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface CollectionI
	{
	}
	public interface CollectionI<T> : CollectionI {
		bool contain(T member);
	}

	public interface CollectionI<T, TEq>:CollectionI<T>
		where TEq:IEqualityComparer<T>,new()

	{

	}


}
