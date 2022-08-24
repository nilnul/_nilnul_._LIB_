using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.op
{
	static public class _MemoizeX
	{
	//[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static Func<TIn, TResult> Memoize<TIn, TResult>(this Func<TIn, TResult> f)
		{
			var cache = new ConcurrentDictionary<TIn, TResult>();
			return a => cache.GetOrAdd(a, f);
		}
		/*
		https://www.aleksandar.io/post/memoization/
		While the Memoize method given above does work with multiple threads, it does not guarantee a single invocation of a generator given function, it’s quite possible when multiple threads call the method that passed function f will be called multiple times.

Let’s try out current implementation. First, we create a function which just returns a what has been passed to it, but it also counts number of times it has been called.

int calls = 0;
		Func<int, int> identity = n =>
		{
			Interlocked.Increment(ref calls);
			return n;
		};
		var memoized = identity.Memoize();
		Parallel.For(0, 1000, i => memoized(0));
Console.WriteLine(calls); // 9
Here, we were calling memoized(0) a 1000 times(with Parallel.For), but our counter says 9. Why is that? The GetOrAdd on Dictionary is called after initial function has returned a result, so it just happens that each thread calls it’s own function as none are present in the dictionary initially.

This may or may not be a problem depending on your use case, but if it is, we can solve this by wrapping our function in Lazy<>, which ensures only one initialization is made.
*/
		public static Func<T, TResult> MemoizeLazy<T, TResult>(this Func<T, TResult> f)
		{
			var cache = new ConcurrentDictionary<T, Lazy<TResult>>();
			return a => cache.GetOrAdd(a, new Lazy<TResult>(() => f(a))).Value;
		}
		/*
		Replacing Memoize with LazyMemoize in our previous example solves the issue with multiple initializations, but it comes with slight performance cost.


var lazyMemoized = thing.LazyMemoize();
		Parallel.For(0, 1000, i => lazyMemoized(0));
Console.WriteLine(calls); // 1 - called just once

	*/
	}
}
