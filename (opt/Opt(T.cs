using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._opt;

namespace nilnul
{

	public interface OptI {
		_opt.ValI val { get; }
	}
	public class Opt<T>:OptI
	{
		private _opt.ValI<T> _val;

		public _opt.ValI<T> val
		{
			get { return _val; }
			set { _val = value; }
		}

		ValI OptI.val
		{
			get
			{
				return _val;
				throw new NotImplementedException();
			}
		}

		public Opt()
		{
			_val = new _opt.None<T>();
		}

		public Opt(T val)
		{
			_val = new _opt.One<T>(val);
		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
