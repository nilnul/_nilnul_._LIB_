using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call
{
	public abstract class CallA<TOp, TArg>:OpArgA<TOp,TArg>
	{

		public CallA(TOp op,TArg arg)
			:base(op,arg)
		{
			
		}

		public override string ToString()
		{
			return $"{op}{arg}";
		}

	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract partial class Call<TOp,TArg,TR>
		:OpArgA<TOp,TArg>
		,EvalI<TR>
		where TOp :nilnul._op.EvalI<TArg,TR>
	{
		public Call(TOp op,TArg arg)
			:base(op,arg)
		{
		}

		public TR eval()
		{
			return op.eval(arg);

			throw new NotImplementedException();
		}
	}


	public abstract partial class Call<TOp,T>
		:OpArgA<TOp,T>
		,EvalI<T>
		where TOp :nilnul._op.EvalI<T>
	{
		public Call(TOp op,T arg)
			:base(op,arg)
		{
			this.arg = arg;
		}

		public T eval()
		{
			return op.eval(arg);

			throw new NotImplementedException();
		}
	}




}
