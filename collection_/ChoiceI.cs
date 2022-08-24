using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection_
{
	/// <summary>
	/// with a least one member to be chosen according to axiom of choice.
	/// axiom of choice in fact defines a type in terms of type theory.
	/// </summary>
	public interface ChoiceI:CollectionI
	{
	}

	public interface ChoiceI<T> : ChoiceI
		,CollectionI<T>

	{
		T choice { get; }
	}

	public interface ChoiceI<T, TEq> : ChoiceI<T>
		where TEq:IEqualityComparer<T>,new()
	{

	}

}
