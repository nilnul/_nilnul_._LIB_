using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	[Serializable]
	public class UnexpectedReachException : Exception
	{
		public UnexpectedReachException() { }
		public UnexpectedReachException(string message) : base(message) { }
		public UnexpectedReachException(string message, Exception inner) : base(message, inner) { }
		protected UnexpectedReachException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
