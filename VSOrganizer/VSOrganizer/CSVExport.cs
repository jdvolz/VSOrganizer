using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VSOrganizer {
	public class TXTExport {
		public static void SaveToTXT(string filename, params ProjectListManager[] managers) {
			StringBuilder sb = new StringBuilder();
			foreach (ProjectListManager manager in managers)
				sb.Append(manager.ToCSV());
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write));
				sw.Write(sb.ToString());
			}
			catch { }
			finally { if (sw != null) sw.Close(); }
		}
	}
}
