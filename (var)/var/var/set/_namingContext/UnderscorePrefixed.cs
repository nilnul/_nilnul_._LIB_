using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.set._namingContext
{
	public class UnderscorePrefixed:nilnul._stream.NextI<string>,nilnul.txt.StreamI
	{

		static public readonly UnderscorePrefixed Singleton = SingletonByDefault<UnderscorePrefixed>.Instance;



		public IEnumerator<string> getEnumerable() {
			foreach (var item in nilnul.txt.str.VarName.COMMON_VAR_NAMES_LOWERCASE)
			{
				yield return item.ToString();
			}

			while (true)
			{
				yield return "_"+	nilnul.txt.stream.eg.Digits.Singleton.next();
			}
		}

		IEnumerator<string> enumerator;

		public UnderscorePrefixed()
		{
			enumerator = getEnumerable();

		}
		public string next()
		{
			enumerator.MoveNext();
			return enumerator.Current;


			throw new NotImplementedException();
		}
	}
}
