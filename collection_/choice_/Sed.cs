using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.set_;

namespace nilnul.collection_.choice_
{
	public class Sed<T, TEq> : 
		nilnul.Box1< nilnul.set_.Sed<T,TEq>>
		,
		ChoiceI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public Sed(set_.Sed<T, TEq> val) : base(val)
		{
		}

		public T choice => this.boxed.en.First();

		public bool contain(T member)
		{
			
			throw new NotImplementedException();
		}
	}
}
