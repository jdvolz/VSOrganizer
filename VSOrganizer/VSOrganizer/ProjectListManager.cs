using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VSOrganizer {
	[Serializable]
	public class ProjectListManager {
		private List<Project> projectList;
		public List<Project> ProjectList { get { return this.projectList; } }
		private string filename;
		private string name;
		public ProjectListManager() {
			projectList = new List<Project>();
		}
		public ProjectListManager(string name, string filename) : this() {
			this.name = name;
			this.filename = filename;
			projectList = ReadFile(GetProjectFileFullPath());
		}
		public static void WriteFile(ProjectListManager manager) {
			StreamWriter sw = null;
			string fullpath = manager.GetProjectFileFullPath();
			try {
				if (File.Exists(fullpath)) File.Delete(fullpath);
				FileInfo fi = new FileInfo(fullpath);
				sw = new StreamWriter(fi.OpenWrite());
				foreach (Project p in manager.projectList) {
					sw.Write(p.ToString());
					sw.WriteLine("||END||");
				}
			}
			catch {}
			finally { if (sw != null) sw.Close(); }
		}
		private static List<Project> ReadFile(string filename) {
			StreamReader sr = null;
			try {
				if (!File.Exists(filename)) return new List<Project>();
				FileInfo fi = new FileInfo(filename);
				sr = new StreamReader(fi.OpenRead());
				List<Project> projects = new List<Project>();
				Project p = null;
				bool newProject = true;
				string line = sr.ReadLine();
				while (line != null) {
					if (newProject) {
						p = new Project(line);
						projects.Add(p);
						newProject = false;
					}
					else if (line.CompareTo("||END||") == 0) {
						newProject = true;
					}
					else {
						if (p != null && line.Length > 0) p.Notes.Add(Note.ReadNote(line));
					}
					line = sr.ReadLine();
				}

				return projects;
			}
			catch { }
			finally { if (sr != null) sr.Close(); }
			return null;
		}
		public static string GetProjectDirectory() {
			return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"Vizonware\Organizer\");
		}
		public string GetProjectFileFullPath() {
			return System.IO.Path.Combine(ProjectListManager.GetProjectDirectory(), this.filename);
		}
		public Project Find(string projectname) {
			return projectList.Find(delegate(Project p) { return p.Name.CompareTo(projectname) == 0; });
		}
		public void Add(Project p) { this.projectList.Add(p); }
		public void Remove(Project p) { this.projectList.Remove(p); }
		public string ToXML() {
			StringBuilder sb = new StringBuilder();
			sb.Append("<ProjectList>\n");
			sb.AppendFormat("<name>{0}</name>\n", XMLExport.ReplaceEntities(this.name));
			foreach (Project p in projectList)
				sb.Append(p.ToXML());
			sb.Append("</ProjectList>\n");
			return sb.ToString();
		}
		public string ToCSV() {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}\n", this.name);
			foreach (Project p in projectList)
				sb.Append(p.ToCSV());
			sb.Append("\n\n");
			return sb.ToString();
		}
	}
}
