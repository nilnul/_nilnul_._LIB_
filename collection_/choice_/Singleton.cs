using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection_.choice_
{
	public abstract class Singleton<T> : 
		ChoiceI<T>
	{
		private T _choice;

		public T choice
		{
			get { return _choice; }
			set { _choice = value; }
		}

		public Singleton(T choice)
		{
			_choice = choice;
		}

		public abstract bool contain(T member);
	}
	public class Singleton<T, TEq>
		: Singleton<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Singleton(T choice) : base(choice)
		{
		}

		public override bool contain(T member)
		{
			return nilnul.Singleton1<TEq>.Instance.Equals(choice, member);
		}
	}
}