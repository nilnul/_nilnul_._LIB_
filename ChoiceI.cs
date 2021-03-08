using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// with a least one member to be chosen according to axiom of choice.
	/// axiom of choice in fact defines a type in terms of type theory.
	/// </summary>
	public interface ChoiceI
	{
	}

	public interface ChoiceI<T> : ChoiceI

	{
		T choice { get; }
	}

	public interface ChoiceI<T, TEq> : ChoiceI<T>
		where TEq:IEqualityComparer<T>,new()
	{

	}

}
