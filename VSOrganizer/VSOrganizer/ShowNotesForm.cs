using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class ShowNotesForm : Form {
		private string highlighted = "";
		public string Highlighted { set { highlighted = value; } }
		private Project myProject;
		public Project MyProject {
			get { return this.myProject; }
			set { this.myProject = value; }
		}
		public ShowNotesForm() { InitializeComponent(); }

		private void btnOk_Click(object sender, EventArgs e) {			
			DialogResult = DialogResult.OK;
			this.Close();
		}
		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void NotesForm_Load(object sender, EventArgs e) {
			this.lblProjectName.Text = myProject.Name;
			if (myProject.Notes != null) {
				Stack<Note> stack = new Stack<Note>();
				foreach (Note n in myProject.Notes)
					stack.Push(n);
				foreach (Note n in stack.ToArray()) 
					richTextBox1.AppendText(n.ToString("{0:f} : \n-----\n{1}") + "\n\n");
				Highlight();
			}
			this.btnAddNote.Focus();
		}
		private void btnAddNote_Click(object sender, EventArgs e) {
			AddNotesForm frm = new AddNotesForm();
			frm.ProjectName = myProject.Name;
			if (frm.ShowDialog() == DialogResult.OK) {
				Note n = new Note(frm.Note, frm.NoteDateTime);
				myProject.Notes.Add(n);
				richTextBox1.Text = (n.ToString("{0:f} : \n-----\n{1}") + "\n\n") + richTextBox1.Text;
				Highlight();
			}
		}
		private void Highlight() {
			if (highlighted.Length == 0) return;
			string[] split = highlighted.ToLower().Split();
			richTextBox1.SelectionStart = 0;
			richTextBox1.SelectionLength = richTextBox1.Text.Length;
			richTextBox1.SelectionBackColor = richTextBox1.BackColor;
			foreach (string s in split) {
				List<int> indices = Search.GetIndicesOf(s, richTextBox1.Text.ToLower());
				foreach (int i in indices) {
					richTextBox1.SelectionStart = i;
					richTextBox1.SelectionLength = s.Length;
					richTextBox1.SelectionBackColor = Color.FromArgb(173, 255, 47);					
				}
			}
		}
	}
}