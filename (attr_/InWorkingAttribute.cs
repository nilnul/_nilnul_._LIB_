using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	[System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
#if !DEBUG
	[Obsolete("Still In Working. If the entity decorated by this attribute is ready, remove this attribute",true)]
#else
	[Obsolete("Still In Working. If the entity decorated by this attribute is ready, remove this attribute",false)]

#endif

	public sealed class InWorkingAttribute : Attribute
	{
		// See the attribute guidelines at 
		//  http://go.microsoft.com/fwlink/?LinkId=85236
		readonly string positionalString;

		// This is a positional argument
		public InWorkingAttribute(string positionalString)
		{
			this.positionalString = positionalString;

			// TODO: Implement code here

		//	throw new NotImplementedException();
		}

		public InWorkingAttribute()
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
