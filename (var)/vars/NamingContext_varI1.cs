using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.var.str.be;
using nilnul.name.str.be;
using nilnul.txt.be;
using nilnul.var.str;
 using nilnul.character.set.be;

namespace nilnul.vars
{
	//[Obsolete("txt::")]
	[Obsolete(nameof(nilnul))]
	public class NamingContext
	{
		static public readonly NamingContext Instance = new NamingContext();

		private Dictionary<VarI1, obj.Name> _namings = new Dictionary<VarI1, obj.Name>();
		public Dictionary<VarI1, obj.Name> namings
		{
			get {
				return _namings;
			}
			set
			{
				value.Keys.AssertDistinct();
				value.Values.AssertDistinct();
				_namings = value;
			}
		}

		private nilnul.txt.StreamI _omega;
		public nilnul.txt.StreamI omega
		{
			get { return _omega; }
			set { _omega= value; }
		}

		private IEnumerator<string> _autoNames;
		public IEnumerator<string> autoNames
		{
			get { return _autoNames; }
			set { _autoNames = value; }
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

		public IEnumerable<nilnul.obj.Name> names
		{
			get
			{
				return _namings.Select(x => x.Value);
			}
		}

		public NamingContext(
			Dictionary<VarI1, Name > namings
			,
			nilnul.txt.StreamI alphabet
		)
		{
			this.namings = namings;
			_omega =(alphabet);
			_autoNames = new nilnul.stream.to.Enumerable<string>(alphabet).GetEnumerator();

		}

		public NamingContext(
			nilnul.txt.StreamI alphabet
):this(
		new Dictionary<VarI1, Name>(),alphabet
	)
		{
			
		}

		public NamingContext()
			: this(
				  nilnul.obj.var.set._naming.UnderscorePrefixed.Singleton
			 )
		{
		}


		public void setName(VarI1 var, string name)
		{
			setName(var, new Name(name));
		}

		public T createVar<T>(string name) where T : VarI1, new()
		{
			var x = new T();
			setName(x, name);
			return x;
		}
		public T getOrCreateVar<T>(string name) where T : VarI1, new() {
			return getOrCreateVar<T>(new Name(name));
		}

		public T getOrCreateVar<T>(Name name) where T : VarI1, new()
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

		public T getVarByName<T>(Name name) where T : VarI1
		{
			if (containName(name))
			{
				return (T)(_namings.Where(x=>x.Value ==name).First().Key );
				
			}
			throw new Exception("no such name");
		}

		public T getVarByName<T>(string name) where T : VarI1
		{
			return getVarByName<T>(new Name(name));

		}

		public bool containName(Name name)
		{
			if (
				this.namings
				.Select(x => x.Value)
				.Contain_eqDefault<Name, nilnul.obj.name.Eq>(name)
			)
			{
				return true;
			}
			return false;
		}

		public bool containName(string name)
		{
			return containName( new Name(name));
		}

		public void setName(VarI1 var, Name name)
		{
			if (this.vars.Contain(var))
			{
				if (
					this.namings
					.Where(x => x.Key != var)
					.Select(x => x.Value)
					.Contain_eqDefault<Name, nilnul.obj.name.Eq>(name)
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
					.Contain_eqDefault<Name, nilnul.obj.name.Eq>(name)
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

		public Name getEnsuredName(VarI1 var)
		{
			if (!_namings.ContainsKey(var))
			{
				var _previousAutoName1 = getNextAutoName();
				setName(var,  _previousAutoName1);
				return _previousAutoName1;
			}
			else
			{
				return _namings[var];
			}
		}

		public Name getNextAutoName()
		{
			_autoNames.MoveNext();
			while ( nilnul.obj.name.str.be_._NotContainX.Contain(names, _autoNames.Current) )
			{
				_autoNames.MoveNext();

			}
			return new Name( _autoNames.Current);
		}
	}
}
