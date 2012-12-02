using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class SearchResultsForm : Form {
		private string highlighted;
		public string Highlighted { set { highlighted = value; } }
		private SortedList<SearchRank, Project> results;
		public SortedList<SearchRank, Project> Results { set { results = value; } }
		public SearchResultsForm() { InitializeComponent(); }
		private void SearchResultsForm_Load(object sender, EventArgs e) {
			if (results != null) {
				foreach (Project p in results.Values)
					dgvActive.Rows.Add(new object[] { p.Name, p.GetLastNote() });
			}
		}	
		private void dgvActive_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { OpenResults();	 }
		private void OpenResults() {
			if (dgvActive.SelectedRows.Count == 0) return;
			DataGridViewRow row = dgvActive.SelectedRows[0];
			Project selected = null;
			foreach (Project p in results.Values)
				if (p.Name.CompareTo(row.Cells[0].Value.ToString()) == 0) selected = p;
			if (selected != null) {
				ShowNotesForm frm = new ShowNotesForm();
				frm.MyProject = selected;
				frm.Highlighted = highlighted;
				frm.ShowDialog();
			}
		}
		private void dgvActive_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyValue == '\r') {
				e.Handled = true;
				OpenResults();
			}			
		}
	}
}