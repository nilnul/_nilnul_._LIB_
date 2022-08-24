using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._op
{
	public class Result<TRet,TXpn>
		where TXpn:Exception
	{
		private TRet _ret;

		public TRet ret
		{
			get { return _ret; }
			set { _ret = value; }
		}

		private TXpn _xpn;

		public TXpn xpn
		{
			get { return _xpn; }
			set { _xpn = value; }
		}
		public Result(TRet ret, TXpn xpn)
		{
			_ret = ret;
			_xpn = xpn;
		}

		public bool isRet() {
			return object.Equals(_xpn , default(TXpn));
		}

		public bool isXpn() {
			return !isRet();
		}

		public Result(TRet ret):this(ret,default(TXpn))
		{

		}

		public override string ToString()
		{
			return isRet()?_ret.ToString():_xpn.ToString();
		}

		static public Result<TRet, TXpn> FroXpn(TXpn xpn) {
			return new Result<TRet, TXpn>(default(TRet), xpn);
		}
	}
}
