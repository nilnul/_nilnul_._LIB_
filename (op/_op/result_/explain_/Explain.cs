using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.exception_;

namespace nilnul._op.result_.explain_
{
	public class RetTxt : Explain<string>
	{
		public RetTxt():this("")
		{

		}
		public RetTxt(string ret) : base(ret)
		{
		}

		public RetTxt(string ret, ExcuseException xpn) : base(ret, xpn)
		{
		}

		public RetTxt(string ret, string excuse):this(ret, new ExcuseException(excuse))
		{

		}

		static public RetTxt FroXpn(string xpn) {
			return new RetTxt(default(string), new ExcuseException(xpn));
		}
	}
}
