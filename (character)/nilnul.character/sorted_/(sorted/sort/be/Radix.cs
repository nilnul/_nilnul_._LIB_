using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.character.str.be;

namespace nilnul.character.sort.be
{
	[Obsolete("Alphabet")]
	public class Radix : nilnul.BeI<str.be.Distinct.Asserted>
	{
		public bool be(Distinct.Asserted obj)
		{
			return obj.val.Length > 1;
			throw new NotImplementedException();
		}

		

		public class Asserted:nilnul.be.Asserted<str.be.Distinct.Asserted, Radix>
		{
			public Asserted(str.be.Distinct.Asserted s):base(s)
			{

			}

			public Asserted(string s):this(new Distinct.Asserted(s))
			{

			}

			public Asserted(IEnumerable<char> s):this(new Distinct.Asserted(character.Str.Chars2Str(s)))
			{

			}



			public const string digits= "0123456789";
			public const string lowers = "abcdefghijklmnopqrstuvwxyz";
			public const string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			public const string digitsUppers = digits + uppers;
			public const string digitsLowers = digits + lowers;

			static public readonly Radix.Asserted Binary = new Asserted("01");
			static public Asserted Create_2before36_upper(int i) {

				return new Asserted(uppers.Take(i));

			}

			static public Asserted Create_2before36_lower(int i) {

				return new Asserted(lowers.Take(i));

			}


		}


	}
}
