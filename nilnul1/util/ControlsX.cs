using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace nilnul
{
	static public class ControlsX
	{

		/// <summary>
		///
		/// </summary>
		/// <param name="pallete"></param>
		/// <param name="children"></param>
		/// <param name="horizontalVertical">
		/// 
		///		true: like this: ||||||||
		/// </param>
		static public void Span(this IEnumerable<Control> c, Control p, bool hv)
		{



			for (int i = 0; i < c.Count(); i++)
			{
				if (hv)
				{
					c.ElementAt(i).Top = 0;

					c.ElementAt(i).Left = p.Width / c.Count() * i;

					c.ElementAt(i).Width = p.Width / c.Count();
					c.ElementAt(i).Height = p.Height;

				}
				else
				{
					c.ElementAt(i).Left = 0;

					c.ElementAt(i).Top = p.Height / c.Count() * i;

					c.ElementAt(i).Height = p.Height / c.Count();
					c.ElementAt(i).Width = p.Width;

				}

			}





		}
	}
}
