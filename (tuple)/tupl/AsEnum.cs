using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl
{
	public class AsEnum:IEnumerable
	{
		private TuplI _tupl;

		public TuplI tupl
		{
			get { return _tupl; }
			set { _tupl = value; }
		}

		public AsEnum(TuplI tupl)
		{
			_tupl = tupl;
		}

		public IEnumerator GetEnumerator()
		{
			if (_tupl is tupl.SansI)
			{
				yield break;
			}
			else
			{
				//must be SeededI
				yield return (_tupl as _seeded.SeedOfObjectI).seed;
				foreach (var item in new AsEnum((_tupl as _seeded.TailI<TuplI>).tail))
				{
					yield return item;
				}
				yield break;
				throw new NotImplementedException();
			}
		}
	}
}
