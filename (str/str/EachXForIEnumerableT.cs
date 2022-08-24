using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	[Obsolete("nilnul.obj.Each")]
	static public partial class EachXForIEnumerableX
	{
		/// <summary>
		/// sequence cannot be null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="sequence"></param>
		/// <param name="action"></param>
		public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
		{
			// argument null checking omitted. null arg will throw exception, problem solved.
			foreach (T item in sequence) action(item);
		}
	}
}
