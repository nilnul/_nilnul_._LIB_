﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul._call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract partial class OpA<TOp>
		
	{
		private TOp _op;
		public TOp op
		{
			get
			{
				return _op;
			}
			set
			{
				_op=value;
			}
		}
		public OpA(TOp op)
		{
			this.op = op;
		}
	}
}
