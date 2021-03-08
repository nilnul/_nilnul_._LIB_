using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.type
{
	public partial class StaticCreate<T>
		where T:new()
	{

		static public T Create() { 

			return new T();

		
		}
	}
}
