using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var._name.txt
{
	public class Be:nilnul.BeI<string>
	{
		static public bool Eval(string s) {
			return s != "" 
				&& nilnul.character.be.NameHead.Eval(s.First()) 
				&& s.Skip(1).All(c => nilnul.character.be.NameTail.Eval(c));
		}

		public bool be(string obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

 	}
}
