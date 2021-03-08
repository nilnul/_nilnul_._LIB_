using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.function
{
	/// <summary>
	/// Function is only a logic or rule, so it doesn't requre more of the input arguments unless the rule cannot proceed with the variable. For the function might have other function such as operator in its logic, so the arguments have to pass through their rules as well, thus form the domain.
	/// 
	/// We 'll have in mind that no more constraints should be placed until the rule is breaked. Specificly, we can use the same function to compute with real numbers as well as random variables, for random varialbes takes real values and the computation goes with the values they took.
	/// 
	/// 
	/// Return tight, input as loose as possible!
	/// 
	/// The range and codomain of f are the same only when f is surjective. range &lt codomain.
	/// 
	/// 
	/// A function is a relation that uniquely associates members of one set with members of another set. More formally, a function from  to  is an object  such that every  is uniquely associated with an object . A function is therefore a many-to-one (or sometimes one-to-one) relation. The set  of values at which a function is defined is called its domain, while the set  of values that the function can produce is called its range. The term "map" is synonymous with function. 


	/// </summary>
	/// <typeparam name="TArgs"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <remarks>
	/// parameter must be able to affect the result.
	/// Note: domain and its complement
	///  when  the object in domain , the function returns a number.
	///  when the object is not in domain, the function throws an exception.
	/// 
	/// </remarks>
	public interface FunctionI
		//:		IElement
	{
		///logic
		///
		///It can return void.
		

		/////domain
		/////

		

		/////Range
		/////
		//ISet<object> range
		//{
		//    get;
		//}

		/// <summary>
		/// how many parameters
		/// </summary>
		//INonnegativeInteger dimension
		//{
		//    get;
		//}

		

	}

	

	
	
}
