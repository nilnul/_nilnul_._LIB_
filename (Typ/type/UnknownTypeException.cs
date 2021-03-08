using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.type
{
	[Serializable]
	public class UnknownTypeException : Exception
	{
		public UnknownTypeException()
			: this("Unknown Type.")
		{ 
		}

		public UnknownTypeException(string message) : base(message) {
		}

		public UnknownTypeException(string message, Exception inner) : base(message, inner) { 
		}



		public UnknownTypeException(Type parent, params Type[] knownSubTypes)
			: base(
			string.Format("Unknown subtype of {0} besides {1}", parent.ToString(), nilnul.ToStrX2.ToStr( knownSubTypes)
			))
		{
		}



		protected UnknownTypeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
