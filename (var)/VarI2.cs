using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface IVar
	{
	}
	public interface IVar<T> : IVar {

	}
	[Obsolete()]
	public interface VarI2<T> : VarI2 {

	}
	public interface VarI3<T> : IVar<T> {

	}

	[Obsolete()]
	public interface VarI2:IVar
	{
	}


	[Obsolete()]
	public abstract class VarA:VarI2
	{

	}


	public class Var3<T>:VarI3<T>
	{

	}

	public class Var3:Var3<object>
	{

	}

	[Obsolete()]

	public class Var2<T>
		:
		VarA
		,
		VarI2<T>
	{

	}

}
