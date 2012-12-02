using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class NewProjectForm : Form {

		public string ProjectName;

		public NewProjectForm() { InitializeComponent(); }

		private void btnOk_Click(object sender, EventArgs e) {
			ProjectName = textBox1.Text;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}