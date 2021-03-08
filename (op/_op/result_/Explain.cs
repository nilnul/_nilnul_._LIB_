using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.exception_;

namespace nilnul._op.result_
{
	public class Explain<TRet> : Result<TRet, nilnul.exception_.ExcuseException>
	{
		public Explain(TRet ret) : base(ret)
		{
		}

		public Explain(TRet ret, ExcuseException xpn) : base(ret, xpn)
		{
		}

		public Explain(TRet ret, string excuse):this(ret, new ExcuseException(excuse))
		{

		}

		static public Explain<TRet> FroXpn(string xpn) {
			return new Explain<TRet>(default(TRet), new ExcuseException(xpn));
		}
	}
}
