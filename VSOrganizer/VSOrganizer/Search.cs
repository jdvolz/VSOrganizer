using System;
using System.Collections.Generic;
using System.Text;
namespace VSOrganizer {
	public class Search {
		public static SortedList<SearchRank, Project> SearchAll(List<ProjectListManager> managers, string q) {
			SortedList<SearchRank, Project> results = new SortedList<SearchRank, Project>();			
			string[] split = q.ToLower().Split();
			foreach (ProjectListManager manager in managers) {
				foreach (Project project in manager.ProjectList) { 
					//fill in the rank
					SearchRank rank = new SearchRank();
					foreach (string word in split) {
						rank.nameCount += CountInstancesOf(word, project.Name.ToLower());
						foreach (Note n in project.Notes)
							rank.notesCount += CountInstancesOf(word, n.Text.ToLower());
					}
					if( !rank.IsZero())results.Add(rank, project);
				}
			}
			return results;
		}
		private static int CountInstancesOf(string target, string source) {
			string temp = source;
			int count = 0;
			while (temp.Length > 0) {
				int ix = -1;
				if ((ix = temp.IndexOf(target, 0, temp.Length)) >= 0) {
					count++;
					temp = temp.Substring(ix+target.Length);
				} else temp = "";
			}
			return count;
		}
		public static List<int> GetIndicesOf(string target, string source) {
			string temp = source;
			List<int> results = new List<int>();
			int start = 0;
			while (temp.Length > 0) { 
				int ix = -1;
				if ((ix = temp.IndexOf(target, start, temp.Length-start)) >= 0) {
					results.Add(ix);
					start = ix + target.Length;
				} else temp = "";
			}
			return results;
		}
	}
	public class SearchRank : IComparable<SearchRank> {
		public int nameCount;
		public int notesCount;
		public bool IsZero() {
			return nameCount == 0 && notesCount == 0;
		}
		public int CompareTo(SearchRank y) {							
				if (nameCount > y.nameCount)
					return -1;
				else if (nameCount == y.nameCount) {
					if (notesCount > y.notesCount)
						return -1;
					else if (notesCount == y.notesCount)
						return 1;
					else
						return 1;
				}
				else
					return 1;			
		}
	}
}
