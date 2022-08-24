using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	/*
	 Pointer types
In an unsafe context, a type may be a pointer type, in addition to a value type, or a reference type. A pointer type declaration takes one of the following forms:

type* identifier;
void* identifier; //allowed but not recommended
The type specified before the * in a pointer type is called the referent type. Only an unmanaged type can be a referent type.

Pointer types don't inherit from object and no conversions exist between pointer types and object. Also, boxing and unboxing don't support pointers. However, you can convert between different pointer types and between pointer types and integral types.
	 */

	public partial interface RefI<T>
	{
	}
}
