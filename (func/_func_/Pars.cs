using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._func_
{
	public interface ParsI<out TPars>
		where TPars: nilnul.var.SortieI
	{
		TPars pars { get; }
	}

	public class Pars<TPars> : ParsI<TPars>
		where TPars: nilnul.var.SortieI

	{
		private TPars _pars;
		public TPars pars
		{
			get
			{
				return _pars;
				//throw new NotImplementedException();
			}
		}

		public Pars(TPars pars)
		{
			_pars = pars;
		}
	}

	


}
