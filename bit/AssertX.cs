﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public partial class AssertX
	{

        static public void AssertFuncTrue<P>(Func<P,bool> func,P arg) {
            if (!func(arg) ) {
                throw new Exception(string.Format("{1} doesn't pass {0}.",func,arg));
           
            }

        
        }
		static public void Eval(bool x) {
			if (!x)
			{
				throw new Exception("Assert true fails.");
				
				
			}
		}

		static public void True(bool x)
		{
			if (!x)
			{
				throw new Exception("Assert true fails.");


			}
		}

		static public void False(bool x)
		{
			if (x)
			{
				throw new Exception("Assert true fails.");


			}
		}

		static public void Eq<T>(T x,T y)
			where T:struct,IEquatable<T>
		{
			AssertX.True(x.Equals( y));
		
		}

		static public void Equals<T>(T x, T y)
		where T : struct,IEquatable<T>
		{
			AssertX.True(x.Equals(y));

		}

		
	}
}
