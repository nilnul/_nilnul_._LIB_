using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op_
{
	/// <summary>
	/// nary, unary, binary ops. excluding ternary or n-ary(n>3) operators.
	/// ternary op such as conditional op can be represented by compounding Plain operators. For example, A?B:C can be rewritten as A?D, where D= (B, C).
	/// </summary>
	public interface PlainI
	{
	}
}
