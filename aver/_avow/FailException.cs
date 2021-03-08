using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._avow
{

	[Serializable]
	public class FailException : Exception
	{
		public FailException() { }
		public FailException(string message) : base(message) { }
		public FailException(string message, Exception inner) : base(message, inner) { }
		protected FailException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
