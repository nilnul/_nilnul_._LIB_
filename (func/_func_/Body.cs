using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._func_
{
	public interface RuleI<out TRule>
		where TRule:nilnul.ExprI

	{
		TRule rule { get; }
	}

	public class Rule<TRule> : RuleI<TRule>
		where TRule: nilnul.ExprI

	{
		private TRule _rule;
		public TRule rule
		{
			get
			{
				return _rule;
				//throw new NotImplementedException();
			}
		}

		public Rule(TRule rule)
		{
			_rule = rule;
		}
	}

	public class Rule<TRule, TRet>
		: Rule<TRule>
		where TRule : nilnul.ExprI<TRet>

	{
		public Rule(TRule rule) : base(rule)
		{
		}
	}
}
