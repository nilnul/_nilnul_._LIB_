﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public interface ClosedOpI<T> : ClosedOpI, OpI<T>
	{
	}
}
