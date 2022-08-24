using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{
	public interface BinaryI<T,TEq>
		:nilnul.op_.binary_.ClosedI1<Set1<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
	{
	}

	public interface BinaryI<T, TEq, TSet>
		:nilnul.op_.binary_.ClosedI1<TSet>
		where TEq:IEqualityComparer<T>,new()
		where TSet:nilnul.Set1<T,TEq>

	{


	}
}
