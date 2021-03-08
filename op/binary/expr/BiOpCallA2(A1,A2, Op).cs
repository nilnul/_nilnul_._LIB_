using System;
using System.Net;

namespace nilnul
{
	public partial class BiOpCallA2<A1,A2,Op>
		:OpCallA<Op>
	{


		private A1 _arg1;

		public A1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}

		private A2 _arg2;

		public A2 arg2
		{
			get { return _arg2; }
			set { _arg2 = value; }
		}
		
		
		

		public BiOpCallA2(A1 a1,A2 a2, Op op ):
			base(op)
		{
			this.arg1 = a1;
			this.arg2 = a2;
			
		}
					

	}
}
