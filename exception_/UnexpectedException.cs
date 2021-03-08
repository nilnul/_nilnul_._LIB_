using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.exception_
{

	[Serializable]
	public class UnexpectedException : Exception
	{
		public UnexpectedException() { }
		public UnexpectedException(string message) : base(message) { }
		public UnexpectedException(string message, Exception inner) : base(message, inner) { }
		protected UnexpectedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
