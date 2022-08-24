using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.var
{
	[Obsolete()]
	public partial class Naming<T>
	{
		private SortedDictionary<string,Var<T>> _namings;

		public SortedDictionary<string,Var<T>> namings
		{
			get { return _namings; }
		}

		public Naming()
		{
			_namings = new SortedDictionary<string, Var<T>>();
		}

		public void add(string name, Var<T> var) {
 

		
		}


		

	}
}
