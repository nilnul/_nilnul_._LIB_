using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.realNumber.set
{
	/// <summary>
	///Is a collection of sets related to X, which is a set. And the element of the collection satisfy the following conditions:
	///
	/// X is element of the set.
	/// 
	/// if A is element of the set, so is the compliment of A.
	/// 
	/// if Ai is elements of the set, so is the union of Ai, given Ai is a sequence of subsets of X
	/// 
	/// </summary>
	public class SigmaAlgebraExpr
	{

		public Set_I universal;
		
		public Set<Set> sigmaField;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="set"></param>
		/// <param name="subsets">a set of sets</param>
		public SigmaAlgebraExpr(Set_I universal)
		{
			
			this.universal=universal;
			

		}

	




		/// <summary>
		/// sets must has no duplicate elements.
		/// </summary>
		/// <param name="sets"></param>
		/// <returns></returns>
		//static public bool IsSigmaAlgebraOf(Set[] sets) {

		//    return


		//        /// all are the subset of given set.
		//        sets.All(
		//            x => x.subSetOf(set)
		//        )

		//        &&

		//        ///the given set is in the sets.
		//        sets.Contains(x)

		//        &&




		//        ///the compliment set of each element is in the sets.
		//        sets.All(
		//            x => x.compliment.subSetOf(set)
		//        )

		//        &&

		//        ///the union of each subsets of sets is in the given set.
		//        sets.Subsets().All(
		//            x => x.Aggregate(
		//                    (w, c) => w + c
		//                ).elementOf(sets)

		//        )



		//    ;

			

 
		//}

		

		

		//static public bool IsSigmaAlgebra(Set<Set> sigmaAlgebra,Set universal) {
		//    return
		//        sigmaAlgebra.All(
		//            x => x.IsSubsetOf(universal)
		//        )

		//        &&

		//        sigmaAlgebra.Contains(univeral)
		//        &&

		//        sigmaAlgebra.All(
		//            x => (sigmaAlgebra.Contains(x.complimentIn(univeral)))
		//        )

		//        &&

		//        sigmaAlgebra.SubsetsUnions().All(
		//            x => x.elementOf(sigmaAlgebra)
		//        )
		//    ;
				




		//}

		//public IEnumerable<List<Set>> Subsets()
		//{
			

		//    List<Set> c;

		//    for (int i = 0; i < 2 ^ this.Length;i++ )
		//    {
		//        for (int j = 0; j < this.Length;i++ )
		//        {
		//            if(i&j==1){
		//                c.Add(this[j]);
		//            }

		//        }



		//        yield return c;
				
				

		//    }
			



		}
	}//class

	static public class SigmaAlgebra_Extension {

		//static public IEnumerable<Set> SubsetsUnions(this Set<Set> sigmaAlgebra) {
		//    return SubsetsUnions<object>(sigmaAlgebra);
		//}


		//static public IEnumerable<Set<T>> SubsetsUnions<T>(this Set<Set<T>> sigmaAlgebra)
		//{


		//    Set<T> c=new Set<T>();

		//    foreach(bool[] combi in Combination.Combinations(sigmaAlgebra.Count)){

		//        for(int i=0;i<combi.Length;i++){
		//            if(combi[i]){
		//                c.UnionWith(sigmaAlgebra.ElementAt(i));
		//            }
		//        }
		//        yield return c;

		//    }
		//}

	//}
}
