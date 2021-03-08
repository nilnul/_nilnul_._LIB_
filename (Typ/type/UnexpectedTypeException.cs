using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.type
{
	[Serializable]
	public class UnexpectedTypeException : Exception
	{
		public UnexpectedTypeException() 
		:this("Unknown Type.")
		{ }

		public UnexpectedTypeException(string message) : base(message) { }

		public UnexpectedTypeException(string message, Exception inner) : base(message, inner) { }



		public UnexpectedTypeException(Type parent,params Type[] knownSubTypes)
			:base(string .Format("Unknown subtype of {0} besides {1}",parent.ToString(),nilnul.ToStrX2.ToStr( knownSubTypes)))
		{
		}
					
					

		protected UnexpectedTypeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
