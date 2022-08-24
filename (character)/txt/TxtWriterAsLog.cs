using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.txt
{
	public partial class TxtWriterAsLog
	{
		private TextWriter _txtWriter;

		public TextWriter txtWriter
		{
			get { return _txtWriter; }
			set { _txtWriter = value; }
		}


		public TxtWriterAsLog(TextWriter writer)
		{
			_txtWriter = writer;

		}

		public void writerDashLine() {
			Writer.WriteDashLine(this._txtWriter);
		}

		public void writeMsgInLines(string msg) {
			Writer.WriteMsgInDashLines(_txtWriter,msg);
		}

		public void writeInLines(Exception exception) {
			writeMsgInLines(exception.Message);
		}


	}
}
