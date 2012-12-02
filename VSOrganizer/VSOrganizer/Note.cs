using System;
using System.Collections.Generic;
using System.Text;

namespace VSOrganizer {
	[Serializable]
	public class Note {
		public DateTime Timestamp;
		public string Text;
		public Note() { }
		public Note(string note) {
			this.Timestamp = DateTime.Now;
			this.Text = note;
		}
		public Note(string note, DateTime then) {
			this.Timestamp = then;
			this.Text = note;
		}
		public override string ToString() { return ToString("p"); }
		public string ToString(string pattern) {
			switch (pattern) { 
				case "s":
					return this.Timestamp.ToString("f") + "|||:" + Text.Replace("\n", "\\n");
				case "p":
					return this.Timestamp.ToString("f") + " : " + Text.Replace("\n", "  ");
				default:
					return string.Format(pattern, this.Timestamp, Text);
			}
			//return string.Format(pattern, this.Timestamp.ToString("f") + "|||:" + Text.Replace("\n", "\\n"));
			//return string.Format(pattern, this.Timestamp.ToString("f") + "|||:" + Text.Replace("\n", "\\n"));
		}
		public static Note ReadNote(string text) {
			Note n = new Note();
			string[] split = text.Split(new string[] { "|||:" }, StringSplitOptions.None);
			n.Timestamp = DateTime.Parse(split[0]);
			n.Text = split[1].Replace("\\n", "\n");
			return n;
		}
		public string ToXML() {
			StringBuilder sb = new StringBuilder();
			sb.Append("<Note>\n");
			sb.AppendFormat("<Timestamp>{0:f}</Timestamp>\n", this.Timestamp);
			sb.AppendFormat("<Text>{0}</Text>\n", XMLExport.ReplaceEntities(this.Text));
			sb.Append("</Note>\n");
			return sb.ToString();
		}
		public string ToCSV() {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("\t{0:f}\t{1}\n", this.Timestamp, this.Text.Replace("\n", " "));
			return sb.ToString();
		}
	}
}
