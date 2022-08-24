using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.var.tupl
{


	public class Seed<THead, TTail>:_seed.Seed<THead,TTail>

		where THead:VarI1
		where TTail: TuplI
	{
		public Seed(THead head, TTail tail):base(head,tail)
		{

		}
	}
}
