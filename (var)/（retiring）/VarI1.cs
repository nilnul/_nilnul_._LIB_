using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[Obsolete()]
	public class Var1<T>:Var1, VarI1<T>
	{


	}
	[Obsolete("nilnul.obj.VarI1")]

	public interface VarI1< out T> : VarI1 {

	}
	[Obsolete()]
	public class Var1:VarI1
	{

		public override string ToString()
		{
			return var.set.NamingContext_ofVarI1.Instance.getEnsuredName(this).val;	
		}
	}


	[Obsolete()]

	public interface VarI1
	{
	}
}
