using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class AboutForm : Form {
		public AboutForm() { InitializeComponent(); }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://www.vizonware.com");
		}

		private void btnOk_Click(object sender, EventArgs e) { this.Close(); }

		private void btnCancel_Click(object sender, EventArgs e) { this.Close();}

		private void AboutForm_Load(object sender, EventArgs e) {
			this.lblVersion.Text = "version " + Application.ProductVersion;
		}
	}
}