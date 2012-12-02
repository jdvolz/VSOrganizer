using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VSOrganizer {
	public class XMLExport {
		public static void SaveToXML(string filename, params ProjectListManager[] managers) {
			StringBuilder sb = new StringBuilder();
			sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
			sb.Append("<Document>\n");
			foreach (ProjectListManager manager in managers)
				sb.Append(manager.ToXML());
			sb.Append("</Document>\n");
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None));
				sw.Write(sb.ToString());
			}
			catch { }
			finally { if (sw != null) sw.Close(); }
		}
		public static string ReplaceEntities(string s) { 
			return s.Replace("<", "&lt;").Replace(">","&gt;").Replace("&", "&amp;").Replace("'","&apos;").Replace("\"", "&quot;");
		}
	}
}
