using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.str
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.str.to.txt.X))]
	static public  class ToTxtX
	{

		public const char SEPERATOR = ',';

		static public string Seperator
		{
			get
			{
				return SEPERATOR.ToString();
			}
		}

		[Obsolete(nameof(ToTxt_byLoop))]
		static public string ToTxt_flat<T>(this IEnumerable<T> vector, string seperator)
		{

			if (vector == null)
			{
				return null;

			}
			if (vector.Any())
			{
				var str = vector.First().ToString();

				foreach (var item in vector.Skip(1))
				{
					str += seperator + (item).ToString();

				}
				return str;

			}
			return "";

		}

		static public string ToTxt_byLoop<T>(this IEnumerable<T> vector, string seperator=",")
		{

			
			if (vector.Any())
			{
				return nilnul.str_.started.X._ToTxt_byLoop(vector,seperator);

			}
			return "";

		}





		static public string ToTxt_flat<T>(this IEnumerable<T> vector, char seperator)
		{

			return ToTxt_flat<T>(vector, seperator.ToString());




		}

		static public string ToTxt_flat<T>(this IEnumerable<T> vector)
		{

			return ToTxt_flat<T>(vector, Seperator);




		}


		[Obsolete("don't recur")]
		static public string ToTxt<T>(this IEnumerable<T> vector, string seperator)
		{

			if (vector == null)
			{
				return null;

			}
			if (vector.Any())
			{
				var str = ToTxt(vector.First(), seperator);

				foreach (var item in vector.Skip(1))
				{
					str += seperator + ToTxt(item);

				}
				return str;

			}
			return "";




		}
		static public string ToTxt_byAggregate<T>(this IEnumerable<T> vector, string seperator)
		{

			bool isEmpty = true;

			return vector.Aggregate(
				"",
				(w, c) =>
				{
					if (isEmpty) { isEmpty = false; return w + c; }
					else
					{
						return w + seperator + c;
					}
				}

			);
		}

		

		[Obsolete()]
		static public string ToTxt(this IEnumerable vector, string seperator)
		{

			return ToTxt(nilnul.X.ToTyped(vector), seperator);


		}

		static public string ToTxt1(this IEnumerable vector, string seperator)
		{

			return ToTxtX.ToTxt_flat(nilnul.X.ToTyped(vector), seperator);


		}

		static public string ToTxt1(this IEnumerable vector)
		{

			return ToTxt1(vector, ",");


		}

		[Obsolete()]

		static public string ToTxt(this IEnumerable vector)
		{

			return ToTxt(vector, ",");


		}

		static public string ToTxt(this object o)
		{
			return ToTxt(o, Seperator);

		}

		static public string ToTxt(this object o, string separator)
		{
			if (o is IEnumerable)
			{
				//return nilnul.element.collection.CollectionTostrX.Tostr((IEnumerable)o);
				return ToTxtX.ToTxt(o as IEnumerable, separator);
			}
			else
			{
				return o.ToString();
			}

		}


		//[Obsolete()]

		//static public string Tostr(this IEnumerable enumerable)
		//{
		//	return Tostr(",");
		//}

		//[Obsolete()]
		//static public string Tostr<T>(this IEnumerable<T> vector)
		//{
		//	return ToTxt<T>(vector, ",");
		//}






	}



}
