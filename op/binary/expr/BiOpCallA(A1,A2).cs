using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	/// <summary>
	/// An Expression with two arguments. The op is not specified here; it can be specified in a subtype, say divideExpression,  which implies an op in the definition, not in the field.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	public abstract partial class BiOpCallA<A1,A2>
	
	{
		private A1 _a1;
		private A2 _a2;
		
		public BiOpCallA(A1 a1,A2 a2){
			this.a1 = a1;
			this.a2 = a2;
		}

		public A1 a1
		{
			get
			{
				return _a1;
			}
			set
			{
				_a1=value;
			}
		}

		public A2 a2
		{
			get
			{
				return _a2;
			}
			set
			{
				_a2=value;
			}
		}


	}
}
