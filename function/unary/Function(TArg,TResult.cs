using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.function.unary
{
	public class Function<TArg,TResult>
	{
		private Func<TArg,TResult> _rule;

		public Func<TArg,TResult> rule
		{
			get { return _rule; }
			set { _rule = value; }
		}
		

		public Function(Func<TArg,TResult> rule)
		{
			this.rule = rule;
		}
					
		
	}
	
}
