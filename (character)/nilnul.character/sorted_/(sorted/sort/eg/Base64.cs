using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.sort.eg
{
	/// <summary>
	/// The particular set of 64 characters chosen to represent the 64 place-values for the base varies between implementations.
	/// For example, MIME's Base64 implementation uses A–Z, a–z, and 0–9 for the first 62 values. Other variations share this property but differ in the symbols chosen for the last two values; an example is UTF-7.
	/// </summary>
	public class Base64_
	{
		static public readonly string Generated = Generate();
		static public string Generate() {
			return LatinDigit.Generate() + "+/";
		}



	}
}
