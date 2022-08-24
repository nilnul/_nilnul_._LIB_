using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.algebra.pargoid.magma.rel
{
	public class Super
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TEq"></typeparam>
		/// <param name="_supMagmaSet"> with op, constitue a magma</param>
		/// <param name="_subMagmaSet">with op, constitute  a magma</param>
		/// <param name="_op"></param>
		/// <returns></returns>
		static public bool _Super<T,TEq>(
			Set<T,TEq> _supMagmaSet
			,

			Set<T,TEq> _subMagmaSet
			,
			Func<T,T,T> _op
			)
			where TEq:IEqualityComparer<T>
		{


			throw new NotImplementedException();
		}
	}
}
