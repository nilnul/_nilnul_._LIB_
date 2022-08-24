using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character
{
	/// <summary>
	/// Alphabet is a set of characters. This set is generally not empty, and should be finite.
	/// </summary>
	 public interface AlphabetI
				: nilnul.collection.recur.FiniteSetI<char>

	{
	}
}
