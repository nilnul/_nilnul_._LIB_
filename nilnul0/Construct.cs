using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface ConstructI<out TResult, in TPar>:nilnul.OpI1<TResult,TPar>
		///where TPar is known
	{

	}


}
