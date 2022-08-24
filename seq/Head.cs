using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.seq
{
	public class Head
	{
		static public IEnumerable<T> Eval<T>(T head, IEnumerable<T> tail) {
			yield return head;
			foreach (var item in tail)
			{
				yield return item;
			}

		}
	}
}
