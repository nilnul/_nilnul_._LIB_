using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.tupl
{

	public interface TuplI<T, T1>
		:TuplI
	{ }

	public interface CoupleI<T, T1> : TuplI {


	}
	public interface DuoI<T>:CoupleI<T,T>
	{
	}


	public interface SingleI : TuplI {

	}

	public interface SingleI<T>:TuplI {

	}

	public interface TripleI { }

	public interface QuadrupleI { }

		public interface QuintupleI { }

	public interface SextupleI
	{


	}

	public interface SeptupleI
	{

	}

	public interface OctupleI
	{


	}

	public interface EmpleI { }

}
