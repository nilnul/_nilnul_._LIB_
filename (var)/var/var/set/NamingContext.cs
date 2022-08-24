using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.var.str.be;
using nilnul.name.str.be;
using nilnul.txt.be;
using nilnul.var.str;
using nilnul.str;
using nilnul.character.set.be;

namespace nilnul.var.set
{
	//[Obsolete(nameof(nilnul.obj.var.set))]

	public class NamingContext
	{
		private Dictionary<Var1, Name.Asserted> _namings;
		public Dictionary<Var1, Name.Asserted> namings
		{
			get { return _namings; }
			set {
				value.Keys.AssertDistinct();
				value.Values.AssertDistinct();
				_namings = value;
			}
		}

		public IEnumerable<Var1> vars {
			get {
				return _namings.Select(x => x.Key);
			}
		}

		public IEnumerable<nilnul.txt.be.Name.Asserted> names {
			get {
				return _namings.Select(x => x.Value);
			}
		}

		public NamingContext(

			Dictionary<Var1, Name.Asserted> namings
			,
			nilnul.character.toset.be.Alphabet.Asserted alphabet
        )
		{
			_namings = namings;
			_omega = new txt.stream.Omega(alphabet);
		}

		private string _reservedPrefix = "_";

		public string reservedPrefix
		{
			get { return _reservedPrefix; }
			set { _reservedPrefix = value; }
		}



		public void setName(Var1 var, Name.Asserted name)
		{
			if ( this.vars.Contain(var))
			{
				if (
					this.namings
					.Where(x=>x.Key!= var)
					.Select(x=>x.Value)
					.Contain_eqDefault<Name.Asserted, nilnul.name.Eq>(name)
				)
				{
					throw new Exception("there are conflicting names.");
				}
				else
				{
					_namings[var] = name;
				}
			}
			else
			{
				if (
					this.namings
					.Select(x=>x.Value)
					.Contain_eqDefault<Name.Asserted, nilnul.name.Eq>(name)
				)
				{
					throw new Exception("there are conflicting names.");
				}
				else
				{
					_namings[var] = name;  // If the specified key is not found, a get operation throws a KeyNotFoundException, and a set operation creates a new element with the specified key.
				}
			}
		}

		public Name.Asserted getEnsuredName(Var1 var) {

			if (!_namings.ContainsKey(var))
			{
				
				setName(var,  _previousAutoName1 =  getNextAutoName());
				return _previousAutoName1;
				
			}
			else
			{
				return _namings[var];
			}
			//return _names[var];

			//throw new NotImplementedException();


		}

		//private nilnul.character.toset.be.Alphabet.Asserted _alphabet;

		//public nilnul.character.toset.be.Alphabet.Asserted alphabet
		//{
		//	get { return _alphabet; }
		//	set { _alphabet = value; }
		//}

		private nilnul.txt.stream.Omega _omega;

		public nilnul.txt.stream.Omega omega
		{
			get { return _omega; }
			set { _omega = value; }
		}

		private Name.Asserted _previousAutoName1;

		public Name.Asserted preAutoName1
		{
			get { return _previousAutoName1; }
			set { _previousAutoName1 = value; }
		}


		//private string _previousAutoName;

		//public string previousAutoName
		//{
		//	get { return _previousAutoName; }
		//	set { _previousAutoName = value; }
		//}


		public Name.Asserted getNextAutoName() {

			return new Name.Asserted( _omega.followedTxt(_previousAutoName1.val).First(
				c=>  nilnul.name.str._NotContainX.NotContain(
					names,c
				) 
			));
		}
	}
}
