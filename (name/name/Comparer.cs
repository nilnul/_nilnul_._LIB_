using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt.be;

namespace nilnul.var.name
{
	public class Comparer
		: IComparer<Name>
	{
		public int Compare(Name x, Name y)
		{
			return x.en.CompareTo(y.en);
			//throw new NotImplementedException();
		}


		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
