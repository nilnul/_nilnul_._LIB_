using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.combinatorics;

namespace nilnul.math.set
{
	public partial class Subset
	{
		

	}
	/// <summary>
	/// Static members
	/// </summary>
	public partial class Subset {
		static public bool IsSubsetOf(FiniteSet child,FiniteSet parent) {
			
		}

	}

	static public class Subset_Extension {


		/// <summary>
		/// return all the subsets of parentSet. the parent set is a group of elements of type T, i.e., T[]
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="parentSet"></param>
		/// <returns></returns>

		static public IEnumerable<List<T>> Subsets<T>(this T[] parentSet)
		{
			

			List<T> c;

			
			for (int i = 0; i < 2 ^ parentSet.Length;i++ )
			{
				for (int j = 0; j < parentSet.Length;i++ )
				{
					if(i&j==1){
						c.Add(parentSet[j]);
					}

				}



				yield return c;
				
				

			}
			



		}
	}
}
