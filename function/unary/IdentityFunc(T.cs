using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.function.unary
{
	public partial class IdentityFunction<T>

	{

		static private readonly IdentityFunction<T> _Instance = new IdentityFunction<T>();
		static public IdentityFunction<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public IdentityFunction()
		{
		}

		public T eval(T x) {

			return x;
		
		}
				

		static public T Eval(T x) {

			return x;
		
		}


	

		

	}
}
