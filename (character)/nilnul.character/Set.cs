using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character
{
	/// <summary>
	/// the M:System.Char.GetUnicodeCategory(System.Char) method usually reflects the current version of the Unicode standard, it may return a character's category based on a previous version of the standard or it may return a category that differs from the current standard in order to preserve backward compatibility. As a result, we recommend that you use the M:System.Globalization.CharUnicodeInfo.GetUnicodeCategory(System.Char) method instead of M:System.Char.GetUnicodeCategory(System.Char).
	/// </summary>
	public class Set:HashSet<char>
	{
	}
}
