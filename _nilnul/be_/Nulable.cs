using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _nilnul.be_
{
	static public class _NulableX
	{
		public static bool Be<T>()
		{
			var type = typeof(T);

			if (Nullable.GetUnderlyingType(type) != null)
				return true;

			if (type.IsClass)
				return true;;
			if (type.IsInterface)
			{
				return true;
			}
			return false;
			

		}

	}
}
