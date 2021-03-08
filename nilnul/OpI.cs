using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface OpI1
	{
	}
	public interface OpI1<out TResult>:OpI1 {
		TResult op();
	}

	public interface OpI1<out TResult, in TPar>:OpI1 {

		TResult op(TPar par);

	}
	public interface OpI1<out TResult, in TPar, in TPar1>:OpI1 {
		TResult op(TPar par, TPar1 par1);
	}


}
