using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.exception_
{

	[Serializable]
	public class ExcuseException : Exception
	{
		public ExcuseException() { }
		public ExcuseException(string message) : base(message) { }
		public ExcuseException(string message, Exception inner) : base(message, inner) { }
		protected ExcuseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
