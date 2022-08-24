using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	[System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]

	[Obsolete("The decorated class is wrongly implemented; it should be revised immedially. Don't use it unless it has been corrected. Use of this would be an error, unless you apply another obsolete with true.",true)]

	public sealed class WronglyImplementationAttribute : Attribute
	{
		// See the attribute guidelines at 
		//  http://go.microsoft.com/fwlink/?LinkId=85236
		readonly string positionalString;

		// This is a positional argument
		public WronglyImplementationAttribute(string positionalString)
		{
			this.positionalString = positionalString;

			// TODO: Implement code here

			throw new NotImplementedException();
		}
		public WronglyImplementationAttribute():this("")
		{

		}

		public string PositionalString
		{
			get { return positionalString; }
		}

		// This is a named argument
		public int NamedInt { get; set; }
	}
}
