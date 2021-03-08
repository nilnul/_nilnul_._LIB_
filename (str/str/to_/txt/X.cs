using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.str.to.txt
{

	/// <summary>
	
	/// </summary>
	static public  class X
	{
		public const char SEPERATOR = ',';

		static public string Seperator
		{
			get
			{
				return SEPERATOR.ToString();
			}
		}

		static public string ToTxt<T>(this IEnumerable<T> vector, string seperator=",")
		{
			if (vector.Any())
			{
				return nilnul.str_.started.X._ToTxt_byLoop(vector,seperator);

			}
			return "";

		}


		static public string ToLines<T>(this IEnumerable<T> vector)
		{
			return ToTxt(vector, Environment.NewLine);

		}


	}
}
