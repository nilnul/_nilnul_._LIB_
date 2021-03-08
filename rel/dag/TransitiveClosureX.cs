using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.rel.dag
{
	/// <summary>
	/// Get the transitive closure of a relation matrix.
	/// </summary>
	public partial class TransitiveClosureX
	{
	

		static public void _InPlaceChange(bool[,] m_square)
		{
			var len = m_square.GetLength(0);


			for (int col = 0; col < len; col++)
			{
				for (int row = 0; row <len; row++)
				{
					if (m_square[row, col])
					{
						for (int k = 0; k < len; k++)
						{
							m_square[row, k] |= m_square[col, k];

							
						}
						
					}

				}

			}

		}

		static public bool[,] _GetNew(bool[,] m_square)
		{
			
			var len = m_square.GetLength(0);
			var r=new bool[len,len];
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					r[i, j] = m_square[i, j];
					
				}
				
			}

			for (int col = 0; col < len; col++)
			{
				for (int row = 0; row < len; row++)
				{
					if (r[row, col])
					{
						
						for (int k = 0; k < len; k++)
						{
							
							r[row, k] |= r[col, k];


						}

					}

				}

			}
			return r;

		}

	




		
	}
}
