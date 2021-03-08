using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str_.seq.be_.distinct
{
	public class Vow<T>:nilnul.be.Vow<str_.SeqI<T>>
	{

		public Vow(IEqualityComparer<T> elEq):base(
			new Distinct<T>(elEq)
			
		)
		{

		}

	}
	public class Vow<T,TEq>:nilnul.be.Vow<str_.SeqI<T>, Distinct<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
	{


	}


}
