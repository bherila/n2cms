﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N2.Collections
{
	public interface IZonedList<T> where T : class, IZoneable
	{
		IList<T> FindByZone(string zoneName);
	}
}
