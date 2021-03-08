using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.alphabet.be
{
	/// <summary>
	/// with at least one chars.
	/// </summary>
	public partial class NonEmpty
	{
		static public bool Eval(AlphabetI a) {
			return a.Any();
		}
		public class Be
			:nilnul.bit.Be<AlphabetI>
		{
			public Be():base(Eval)
			{
			}
		}

		public class Asserted
			:nilnul.bit.be.Asserted<AlphabetI,Be>
		{
			public Asserted(AlphabetI x)
				:base(x)
			{

			}
			
		}


	}
}
