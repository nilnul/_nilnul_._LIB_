using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.txt
{
	public partial class Writer
	{
		static public void WriteDashLine(TextWriter tw) {
			tw.WriteLine("----------------------------------");

		}

		static public void WriteMsgInDashLines(TextWriter writer,string msg) {
			WriteDashLine(writer);
			writer.WriteLine(msg);
			WriteDashLine(writer);
		}
		static public void WriteMsgInDashLines(TextWriter writer, Exception exception) {
			WriteMsgInDashLines(writer,exception.Message);
			
		}

	}
}
