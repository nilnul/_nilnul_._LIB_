using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public class Txt2Enum
	{
		static public T ParseEnum<T>(string txt) {
			return (T)Enum.Parse(typeof(T), txt);
		}

		static public T? TryParse<T>(string txt)
			where T:struct
		{
			try
			{
				return ParseEnum<T>(txt);

			}
			catch (Exception)
			{

				return null;
			}
		}
	}
}
