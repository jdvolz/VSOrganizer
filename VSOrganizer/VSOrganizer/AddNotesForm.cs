using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class AddNotesForm : Form {

		public string ProjectName;
		public string Note;
		public DateTime NoteDateTime;

		public AddNotesForm() { InitializeComponent(); }

		private void btnOk_Click(object sender, EventArgs e) {
			Note = richTextBox1.Text;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void NotesForm_Load(object sender, EventArgs e) {
			this.lblProjectName.Text = ProjectName.CompareTo("") == 0 ? "" : ProjectName;
			NoteDateTime = DateTime.Now;
			this.richTextBox1.Focus();
		}
	}
}