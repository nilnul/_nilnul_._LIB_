using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.rel
{
	public class RelMatrix
	{
		static public List<Tuple<T, T>> _Create_elementsLenEqSquareDimenesion<T>(List<T> elements, bool[,] _square)
		{
			var r = new List<Tuple<T, T>>();

			for (int i = 0; i < elements.Count; i++)
			{
				for (int j = 0; j < elements.Count; j++)
				{
					if (_square[i, j])
					{
						r.Add(new Tuple<T, T>(elements[i], elements[j]));

					}
				}
			}
			return r;
		}
	}
}
