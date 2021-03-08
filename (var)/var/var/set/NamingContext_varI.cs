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
	[Obsolete("nilnul.obj.var.set.")]
	public class NamingContext_ofVarI
	{

		static public readonly NamingContext_ofVarI Instance = new NamingContext_ofVarI();

		private Dictionary<VarI1, Name.Asserted> _namings = new Dictionary<VarI1, Name.Asserted>();
		public Dictionary<VarI1, Name.Asserted> namings
		{
			get { return _namings; }
			set
			{
				value.Keys.AssertDistinct();
				value.Values.AssertDistinct();
				_namings = value;
			}
		}

		public void clean()
		{
			_namings.Clear();
		}

		public IEnumerable<VarI1> vars
		{
			get
			{
				return _namings.Select(x => x.Key);
			}
		}

		public IEnumerable<nilnul.txt.be.Name.Asserted> names
		{
			get
			{
				return _namings.Select(x => x.Value);
			}
		}

		public NamingContext_ofVarI(

			Dictionary<VarI1, Name.Asserted> namings
			,
			nilnul.character.toset.be.Alphabet.Asserted alphabet
		)
		{
			this.namings = namings;
			_omega = new txt.stream.Omega(alphabet);
		}

		public NamingContext_ofVarI(
			nilnul.character.toset.be.Alphabet.Asserted alphabet
)
		{
			_omega = new txt.stream.Omega(alphabet);

			_namings = new Dictionary<VarI1, Name.Asserted>();


		}

		public NamingContext_ofVarI()
			: this(
					  character.toset.be.Alphabet.Asserted.CreateDigits()
			 )
		{

		}

		private string _reservedPrefix = "_";

		public string reservedPrefix
		{
			get { return _reservedPrefix; }
			set { _reservedPrefix = value; }
		}

		public void setName(VarI1 var, string name)
		{
			setName(var, new Name.Asserted(name));
		}

		public T createVar<T>(string name) where T : VarI1, new()
		{
			var x = new T();

			setName(x, name);
			return x;
		}
		public T getOrCreateVar<T>(string name) where T : VarI1, new() {
			return getOrCreateVar<T>(new Name.Asserted(name));

		}

		public T getOrCreateVar<T>(Name.Asserted name) where T : VarI1, new()
		{
			if (containName(name))
			{
				return getVarByName<T>(name);
				
			}
			else
			{
				var v = new T();
				setName(v, name);
				return v;
			}

		}

		public T getVarByName<T>(Name.Asserted name) where T : VarI1
		{
			if (containName(name))
			{
				return (T)(_namings.Where(x=>x.Value ==name).First().Key );
				
			}

			throw new Exception("no such name");

		}

		public T getVarByName<T>(string name) where T : VarI1
		{
			return getVarByName<T>(new Name.Asserted(name));

		}




		public bool containName(Name.Asserted name)
		{
			if (
				this.namings
				.Select(x => x.Value)
				.Contain_eqDefault<Name.Asserted, nilnul.name.Eq>(name)
			)
			{
				return true;
			}
			return false;


		}

		public bool containName(string name)
		{
			return containName( new Name.Asserted(name));


		}




		public void setName(VarI1 var, Name.Asserted name)
		{
			if (this.vars.Contain(var))
			{
				if (
					this.namings
					.Where(x => x.Key != var)
					.Select(x => x.Value)
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
					.Select(x => x.Value)
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

		public Name.Asserted getEnsuredName(VarI1 var)
		{

			if (!_namings.ContainsKey(var))
			{

				setName(var, _previousAutoName1 = getNextAutoName());
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

		private Name.Asserted _previousAutoName1 = new Name.Asserted("_");

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


		public Name.Asserted getNextAutoName()
		{

			return new Name.Asserted(_omega.followedTxt(_previousAutoName1.val).First(
				c => nilnul.name.str._NotContainX.NotContain(
					names, c
				)
			));
		}

	}
}
