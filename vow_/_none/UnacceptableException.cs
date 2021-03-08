using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.vow_._none
{

	[Serializable]
	public class UnacceptableException : ArgumentException
	{
		public UnacceptableException() { }
		public UnacceptableException(string message) : base(message) { }
		public UnacceptableException(string message, Exception inner) : base(message, inner) { }
		protected UnacceptableException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
