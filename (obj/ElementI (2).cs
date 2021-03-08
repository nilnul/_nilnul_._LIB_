using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;


namespace nilnul.op.expr
{
	

	/// <summary>
	/// everything is an IElent.
	/// If the IELent is saved in the database, what should we do?
	/// 
	/// This is a little like json object except that the key is not only string but also other objects.
	/// </summary>
	
	public partial interface ElementI
	{
		
		/// <summary>
		/// implicit public.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// 
		[Obsolete("we don't need this.")]
		object this[object key]{
			get;
			set;
		}

		Dictionary<object, object> extendedProperties
		{
			get;
			set;
		}

		DataTable tableFormat
		{
			get;
		}


	}

}
