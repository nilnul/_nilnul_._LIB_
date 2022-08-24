using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.set.be_.any.vow;

namespace nilnul.set_
{
	public interface SedI
	{
	}
	public interface SedI<T,TEq> : SetI<T,TEq>
		where TEq:IEqualityComparer<T>,new()

	{
		nilnul.set.be_.any.vow.En<T, TEq> set { get; }
	}

	public class Sed<T, TEq> :
		nilnul.set.be_.any.vow.En<T, TEq>
		,
		SedI<T, TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		public Sed(Set1<T, TEq> val) : base(val)
		{
		}

		public En<T, TEq> set => this;

		public T[] arr => this.en.ToArray();

		public IEqualityComparer<T> eleEq => nilnul.Singleton1<TEq>.Instance;
	}
}
