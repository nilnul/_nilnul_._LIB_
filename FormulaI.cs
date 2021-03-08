using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// establish or expand one definition as a computation of other known parameters. For example, we define speed as distance/duration. Formula can be expressed as func or a production rule as in a context-free language.
	/// speed ≔ displace / duration
	/// </summary>
	public interface FormulaI
	{
	}

	public abstract class FormulaA
	{
		public const char CHAR = '≝';// 225D equal to by definition
	}
}
