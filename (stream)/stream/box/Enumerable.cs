using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stream.box
{

	
	public class EnumerableAs_default<T>:_stream.StreamA<T>
	{

		//private IEnumerable<T> _enumerable;

		//public IEnumerable<T> enumerable
		//{
		//	get { return _enumerable; }
		//	set { _enumerable = value; }
		//}


		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			//set { _enumerator = value; }
		}


		
		



		public EnumerableAs_default(IEnumerable<T> str)
		{
				_enumerator = str.GetEnumerator();
		//_enumerable = str;
		}

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
		public override T next()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
		{
			return _enumerator.MoveNext() ? _enumerator.Current : default(T);

			throw new NotImplementedException();
		}

		//public override IEnumerator<T> GetEnumerator()
		//{
		//	return _enumerator;

		//	throw new NotImplementedException();
		//}

		
	}


}
