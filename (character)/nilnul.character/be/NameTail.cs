using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character.be
{
	/// <summary>
	/// can occur anywhere in a name
	/// </summary>
	public class NameTail
	{
		static public bool Eval(char c) {
			return
				c=='_' ||
				!char.IsControl(c)
				//&& !char.IsDigit(c) 	///In addition to including digits, numbers include characters, fractions, subscripts, superscripts, Roman numerals, currency numerators, and encircled numbers.This method contrasts with the IsDigit method, which determines whether a Char is a radix-10 digit.
				//&& !char.IsHighSurrogate(c)
				//&& !char.IsLowSurrogate(c) 
				//&& !char.IsNumber(c) 
				&& !char.IsPunctuation(c)
				&& !char.IsSeparator(c)
				&& !char.IsSurrogate(c)  //if c is either a high surrogate or a low surrogate; otherwise, false.
				&& !char.IsSymbol(c)    /*Symbols in the Unicode standard are a loosely defined set of characters that include the following:
						•Currency symbols.
						•Letterlike symbols, which include a set of mathematical alphanumeric symbols as well as symbols such as ℅, №, and ™.
						•Number forms, such as subscripts and superscripts.
						•Mathematical operators and arrows.
						•Geometric symbols.
						•Technical symbols.
						•Braille patterns.
						•Dingbats.
				*/

				&& !char.IsWhiteSpace(c)
				//&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.ClosePunctuation )
				//&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.ConnectorPunctuation)
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.EnclosingMark)

				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.Format)

				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.ModifierLetter)

				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.NonSpacingMark)
				//&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherNotAssigned)
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.ParagraphSeparator)
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.PrivateUse)
				
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.SpaceSeparator)
				
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.SpacingCombiningMark)
				&&!( System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.TitlecaseLetter)
			

				;
				

		}
	}
}
