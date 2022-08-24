using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.stream.eg
{
	public class VarName:nilnul._stream.NextI<string>,nilnul.txt.StreamI
	{

		static public readonly VarName Singleton = SingletonByDefault<VarName>.Instance;

		public IEnumerable<string> getEnumerable() {
			foreach (var item in str.VarName.COMMON_VAR_NAMES_LOWERCASE)
			{
				yield return item.ToString();
			}

			while (true)
			{
				yield return "_"+	Digits.Singleton.next();
			}
		}

		public string next()
		{

			throw new NotImplementedException();
		}
	}
}
