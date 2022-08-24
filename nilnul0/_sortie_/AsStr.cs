using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str_;
using nilnul.str_.seq_;

namespace nilnul._sortie_
{
	public interface AsStrI<T>:BlankI
	{
		nilnul.str_.seq_.Distinct<T> asStr { get; }
	}

	public interface AsStrI<T, TEq>:BlankI
		where TEq:IEqualityComparer<T>, new()
	{
		nilnul.str_.seq_.Distinct<T, TEq> asStr{ get; }
	}

	public abstract class AsStrA<T, TEq>
		: nilnul.str_.seq_.Distinct<T, TEq>
		,
		AsStrI<T, TEq>
		where TEq : IEqualityComparer<T>, new()

	{
		public AsStrA(SeqI<T> val) : base(val)
		{
		}

		public Distinct<T, TEq> asStr => this;
	}
}
