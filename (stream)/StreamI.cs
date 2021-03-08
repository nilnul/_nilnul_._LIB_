using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface StreamI:_stream_.BlankI
	{
	}
	public interface StreamI<T>
		:_stream_.NextI<T>, StreamI
	{

	}
}
