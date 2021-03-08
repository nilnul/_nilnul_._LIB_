using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// can dynamically assign a[0] a[1] to variables.
	/// can assign to dynamical list of vars.
	/// </remarks>
	/// 
	[Obsolete("txt::nilnul.obj.set.Naming")]
	public partial class NamingContext
	{

		static public NamingContext StaticContext = new NamingContext();



		static public void Name(object var, string name) {
			StaticContext.name(var, name);
		}

		static public string Name(object var ) {
			return StaticContext.name(var);
		}

		private Dictionary<object, string> _names = new Dictionary<object, string>();

		public Dictionary<object, string> names
		{
			get { return _names; }
			set
			{


				_names = value;

			}
		}


		public IEnumerable<string> names2
		{
			get
			{
				return _names.Values;
			}
		}

	
		public void name(object var, string name)
		{
			//nilnul.NotNullX.AssertIsNotNull(var);
			if (string.IsNullOrEmpty(name))
			{
				throw new Exception();
			}

			if (_names.ContainsKey(var))
			{
				_names[var] = name;

			}
			else
			{
				_names.Add(var, name);
			}
			var names = new HashSet<string>(names2);
			if (names.Count()!=_names.Count())
			{

				throw new Exception("there are conflicting names.");
				
			}

		}





		public string name(object var) {

			return _names.ContainsKey(var)? _names[var]:null;
		
		}
	
		public string name_ensure(object var) {

			return _names.ContainsKey(var)? _names[var]:null;
		
		}


	}
}
