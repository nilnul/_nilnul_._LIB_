using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op.expr
{
	/// <summary>
	/// an element stands for a concept. The concept might depends on no others and be accepted as is. The user use the concept because he already knows what the concept means. It reflects:
	/// the axioms in math,
	/// or the creation in religion.
	/// Other element then can derive from these predefined elements.
	/// 
	/// This is abstract of all the things considered.
	/// </summary>
	public partial class Element
	{
		private Dictionary<object, object> _members;

		public object this[object key] {
			get {
				if (_members==null)
				{
					return null;
					
				}
				if (_members.ContainsKey(key))	//http://msdn.microsoft.com/en-us/library/9tee9ht2(v=VS.110).aspx, throws keyNotFoundException
				{
					return _members[key];
					
				}
				return null;
			}
			
		
		}


	}
}
