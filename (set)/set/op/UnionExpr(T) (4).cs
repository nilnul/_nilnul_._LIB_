using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;
//using nilnul.computer.humanInterface;
//using nilnul.lang.op.multi.expr;
using nilnul;

namespace nilnul.collection.set
{
	public class UnionExpr<T>
		: MultiOpExprA<SetI,SetI<T> >
		, UnionExprI<T>
	{

		public UnionExpr(params SetI<T>[] operands):base(operands) {
			
		}


		public override MultiOpI<SetI> op
		{
			get
			{
				return Union.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#region ISet<T> Members

		public bool? hasElement(T element)
		{
			bool? r=false;

			foreach (var set in operands)
			{
				if (set.hasElement(element)==true)
				{
					return true;
					
				}
				if (set.hasElement(element)==null)
				{
					r = null;
				}
			}
			return r;
		}

		#endregion

		

		/// <summary>
		/// todo: method call according to runtime type or compile type?  the latter maybe, for this should be decided at compile time.
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>

		
	}
}
