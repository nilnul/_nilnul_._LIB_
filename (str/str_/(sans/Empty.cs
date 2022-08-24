using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public class Empty<T> : StrA<T>,EmptyI
	{
		public override IEnumerator<T> GetEnumerator()
		{
			yield break;
			//throw new NotImplementedException();
		}
	}
}
