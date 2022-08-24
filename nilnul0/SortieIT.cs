using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str_;

namespace nilnul
{
	public interface SortieI<T>:_sortie_.BlankI,_sortie_.AsStrI<T>
	{
	}

	public interface SortieI<T, TEq> : _sortie_.BlankI, _sortie_.AsStrI<T, TEq>
		where TEq:IEqualityComparer<T>,new()
	{
	}


	public class Sortie<T, TEq> :
		_sortie_.AsStrA<T, TEq>
		where TEq : IEqualityComparer<T>, new()

	{
		public Sortie(SeqI<T> val) : base(val)
		{
		}

		public Sortie():this(new Seq<T>())
		{

		}
	}
}
