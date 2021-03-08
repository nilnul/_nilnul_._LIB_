using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface SetI
	{

	}

	public interface SetI<T>
	{
		T[] arr { get; }

		IEqualityComparer<T> eleEq { get; }
	}

	public interface SetI<T, TEq>
		:SetI<T>
		where TEq:IEqualityComparer<T>,new()
	{

	}

	public class Set1<T,TEq>
		:HashSet<T>, SetI<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		public Set1():base(nilnul.Singleton1<TEq>.Instance)
		{

		}

		public Set1(IEnumerable<T> vals):base( vals, nilnul.Singleton1<TEq>.Instance)
		{

		}

		public T[] arr =>this.ToArray();

		public IEqualityComparer<T> eleEq => nilnul.Singleton1<TEq>.Instance;
	}
}