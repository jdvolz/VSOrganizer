using System;
using System.Collections.Generic;
using System.Text;

namespace VSOrganizer {
	[Serializable]
	public class Project {
		public string Name;
		public List<Note> Notes;
		public Project(string name) { Name = name; Notes = new List<Note>(); }
		public Project(string name, List<Note> notes) { Name = name; Notes = notes; }
		public Note GetLastNote() {
			if (Notes != null && Notes.Count > 0) return Notes[Notes.Count - 1];
			return null;
		}
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Name + "\n");
			foreach (Note nt in Notes)
				sb.AppendLine(nt.ToString("s"));
			return sb.ToString();
		}
		public string ToXML() {
			StringBuilder sb = new StringBuilder();
			sb.Append("<Project>\n");
			sb.AppendFormat("<name>{0}</name>\n", XMLExport.ReplaceEntities(this.Name));
			foreach (Note n in Notes)
				sb.Append(n.ToXML());
			sb.Append("</Project>\n");
			return sb.ToString();
		}
		public string ToCSV() {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}\n", this.Name);
			foreach (Note n in Notes)
				sb.Append(n.ToCSV());
			sb.Append("\n");
			return sb.ToString();
		}
	}
}
