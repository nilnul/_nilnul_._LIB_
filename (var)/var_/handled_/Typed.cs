using nilnul.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var_.handled_
{
	public interface TypedI
		:
		nilnul.var_.HandledI
		,
		_typed_.TypeI
		
	{

	}

	public abstract class TypedA
		: nilnul.var_.Handled
		,
		TypedI
	{
		public TypedA(Handle val) : base(val)
		{
		}

		public abstract Type type { get; }
	}
	public  class Typed
		: nilnul.var_.handled_.TypedA
		,
		TypedI
	{
		private Type _type;

		

		public override Type type => _type;

		public Typed(Handle val, Type type) : base(val)
		{
			_type = type;
		}

	}


}
