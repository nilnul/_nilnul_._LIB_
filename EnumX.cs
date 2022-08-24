using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// used in enum member:
	///		[field:Description("OEM")]
	/// </remarks>
	static public class EnumX
	{
		public static string Description0txt<T>(this T enumInstance)
			where T : Enum
		{
			// get the field 
			//var field = ;
			var customAttributes = enumInstance.GetType().GetField(
				enumInstance.ToString()
				//,
				//BindingFlags.Static | BindingFlags.Public
			).GetCustomAttributes(typeof(T), false);

			if (customAttributes.Length > 0)
			{
				return (customAttributes[0] as DescriptionAttribute).Description;
			}
			else
			{
				return enumInstance.ToString();
			}
		}
	}
}
