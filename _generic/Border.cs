using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._generic
{
	public class Border<T>
	{
		private bool _openFalseCloseTrue;

		public bool openFalseCloseTrue
		{
			get { return _openFalseCloseTrue; }
			set { _openFalseCloseTrue = value; }
		}

		private T _mark;

		public T mark
		{
			get { return _mark; }
			set { _mark = value; }
		}

		public Border(T mark, bool open0close1)
		{
			_openFalseCloseTrue = open0close1;
			_mark = mark;
		}
	}
}
