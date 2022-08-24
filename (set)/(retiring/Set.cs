using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{


	[Obsolete("nilnul.obj")]
	public class Set_eqDefault<T,TEq>
		:Set<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		public Set_eqDefault():base(SingletonByDefault<TEq>.Instance)
		{

		}

		public Set_eqDefault(IEnumerable<T> vals):base( SingletonByDefault<TEq>.Instance ,vals)
		{

		}
		
	}

	[Obsolete("nilnul.obj")]

	public class Set<T,TEq>:HashSet<T>
		where TEq:IEqualityComparer<T>
	{

		private TEq _elementEq;

		public TEq elementEq
		{
			get { return _elementEq; }
			private set { _elementEq = value; }
		}

		public Set(TEq eq):base(eq)
		{
			_elementEq = eq;

		}

		public Set(TEq eq, IEnumerable<T> vals):base(vals,eq)
		{
			_elementEq = eq;

		}

		public void add(IEnumerable<T> vals) {

			foreach (var item in vals)
			{
				base.Add(item);
			}

		}

		public void add(T item) {

			
				base.Add(item);
			

		}

	}

	[Obsolete("nilnul.obj")]

	public class Set<T>:Set<T,EqualityComparer<T>>
	{
		public Set():base(EqualityComparer<T>.Default)
		{

		}

		public Set(IEnumerable<T> objs):base(EqualityComparer<T>.Default, objs)
		{

		}
	}
}
