using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul
{
   static  public class StrX
    {
		public const string CRLF = "\r\n";

		public static string visibleChars = "0123456789abcdefghijklmnopqrstuvwxyz_";





		static public string AppendCrlf(this string s)
		{
			return s + CRLF;

		}



		static public string Generate(int length)
		{
			StringBuilder s = new StringBuilder();
			Random r = new Random();
			for (int i = 0; i < length; i++)
			{
				s.Append(visibleChars[r.Next(visibleChars.Length)]);

			}
			return s.ToString();
		}

	   static public string Repeat(string x, int times) {
		   return Repeat(x, (BigInteger)times );
	   }

	   static public string Repeat(string x, BigInteger times)
	   {
		   if (times>0)
		   {
			   throw new Exception();
			   
		   }
		   

		   StringBuilder sb = new StringBuilder();
		   while (times>0)
		   {
			   times--;
			   sb.Append(x);
			   
		   }
		  
		   return sb.ToString();
	   }

	   static public string Repeat(object x, int times)
	   {
		   return Repeat(x.ToString(), times);
	   }

	   static public string Repeat(object x, BigInteger times)
	   {
		   return Repeat(x.ToString(), times);
	   }

	  
    }
}
