using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("_nilnul_._LIB_")]
[assembly: AssemblyDescription("the first dll of nilnul lib; this will ironize the env for nilnul lib onward, and undefined terms will be defined here to make way for nilnul.obj which introduces the fundamental world-of-view for how nilnul lib to treat things")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("nilnul.com")]
[assembly: AssemblyProduct("_nilnul_._LIB_")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("_nilnul_._LIB_")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("da68ef6e-47be-4c9f-a49a-f1e66b4aed1f")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0.1")]
[assembly: AssemblyFileVersion("1.0.2.0")]



/*
::Where should we place generic type?

Generic is not placed here, because the TypeParameter inherits from a specific type (not necessarily the top type-Object); so it's better to place the gereric type to the topest type conforming to the type constraints, for example, we can place generic type with constraintsless parameter into the project "nilnul.obj"
	 */
