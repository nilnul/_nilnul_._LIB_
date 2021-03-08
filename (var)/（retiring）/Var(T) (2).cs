using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class Var<T>
		:VarI<T>
		

	{

		static private Dictionary<string, Var<T>> _newedInstances;

		static  Var() {
			_newedInstances = new Dictionary<string, Var<T>>();	
		}


		static public Var<T> CreateInstance(string name) {

			return new Var<T>(name);
			
		}

		static public Var<T> GetOrCreateInstance(string name)
		{

			if (_newedInstances.ContainsKey(name))
			{
				return _newedInstances[name];
				
			}
			return new Var<T>(name);

		}

		static public bool Remove(string name) {
			return _newedInstances.Remove(name);
		}

		static public Var<T> GetInstance(string name) { 
						if (_newedInstances.ContainsKey(name))
			{
				return _newedInstances[name];
				
			}
			return null;
		}


		static public bool ExistInstance(string name) { 
			return _newedInstances.ContainsKey(name);
		}


		public string name
		{
			get;
			set;
		}


	
		public Var(string name) {

			//if (_newedInstances.ContainsKey(name))
			//{
			//    throw new ArgumentException("Variable with the name ( "+name+" ) already exist.");
			//}
			try
			{
				_newedInstances.Add(name, this);

			}
			catch (Exception)
			{
				throw new ArgumentException("Variable with the name ( " + name + " ) already exists.");
			
			    
			}

			this.name = name;

			
		}

		

		~Var()
		{
			//Console.WriteLine("~{0}",name);
			_newedInstances.Remove(name);
		}


		public override string ToString()
		{
			return name;
		}

		
	}
}
