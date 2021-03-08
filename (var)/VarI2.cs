using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface VarI2
	{
	}
	public abstract class VarA:VarI2
	{

	}

	public interface VarI2<T> : VarI2 {

	}

	public class Var2<T>
		:
		VarA
		,
		VarI2<T>
	{

	}

}
