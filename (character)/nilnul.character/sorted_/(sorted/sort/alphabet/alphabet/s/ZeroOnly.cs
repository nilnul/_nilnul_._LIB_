using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.alphabet.s
{
	/// <summary>
	/// just 0. Only one char.
	/// </summary>
	public partial class ZeroOnly
		:Alphabet
		,
		nilnul.collection.SetI3<char>
	{

		public IEnumerator<char> GetEnumerator()
		{
			yield return '0';

		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
