using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VSOrganizer {
	public partial class frmMain : Form {
		private ProjectListManager Active;
		private ProjectListManager Waiting;
		private ProjectListManager Archive;
		private Dictionary<DataGridView, ProjectListManager> dgv2plm;
		private string ActiveFile = "active.vso";
		private string WaitingFile = "waiting.vso";
		private string ArchiveFile = "archive.vso";

		#region Constructors
		public frmMain() {
			InitializeComponent();
			//Active = new List<Project>();
			//Waiting = new List<Project>();
			//Archive = new List<Project>();
		}

		#endregion

		#region Click handlers

		private void btnActiveDown_Click(object sender, EventArgs e) { Down(dgvActive); }
		private void btnActiveNotes_Click(object sender, EventArgs e) { ShowNotes(dgvActive); }
		private void btnActiveNew_Click(object sender, EventArgs e) { NewProject(dgvActive, Active); }
		private void btnWaitingUp_Click(object sender, EventArgs e) { Up(dgvWaiting); }
		private void btnWaitingDown_Click(object sender, EventArgs e) { Down(dgvWaiting); }
		private void btnWaitingNotes_Click(object sender, EventArgs e) { ShowNotes(dgvWaiting); }
		private void btnWaitingNew_Click(object sender, EventArgs e) { NewProject(dgvWaiting, Waiting); }
		private void btnArchiveUp_Click(object sender, EventArgs e) { Up(dgvArchive); }
		private void btnArchiveNotes_Click(object sender, EventArgs e) { ShowNotes(dgvArchive); }
		private void btnArchiveNew_Click(object sender, EventArgs e) { NewProject(dgvArchive, Archive); }

		#endregion

		#region Form Load

		private void frmMain_Load(object sender, EventArgs e) {
			Active = new ProjectListManager("Active", ActiveFile);
			Waiting = new ProjectListManager("Waiting", WaitingFile);
			Archive = new ProjectListManager("Archive", ArchiveFile);
			dgv2plm = new Dictionary<DataGridView, ProjectListManager>();
			dgv2plm.Add(dgvActive, Active);
			dgv2plm.Add(dgvWaiting, Waiting);
			dgv2plm.Add(dgvArchive, Archive);
			LoadDataViewGrid(dgvActive, Active);
			LoadDataViewGrid(dgvWaiting, Waiting);
			LoadDataViewGrid(dgvArchive, Archive);
			this.Text += " (v" + Application.ProductVersion + ")";
		}

		#endregion

		#region Private methods

		private void LoadDataViewGrid(DataGridView dgv, ProjectListManager manager) {
			if (dgv == null || manager == null) return;
			string target = "";
			if (dgv.SelectedRows.Count > 0) {
				target = dgv.SelectedRows[0].Cells[0].Value.ToString();
			}
			dgv.Rows.Clear();
			foreach (Project p in manager.ProjectList)
				dgv.Rows.Add(new object[] { p.Name, p.GetLastNote() });
			if (target.CompareTo("") != 0) {
				foreach (DataGridViewRow row in dgv.Rows)
					if (row.Cells[0].Value.ToString().CompareTo(target) == 0) row.Selected = true;
			}
		}

		private void SelectRow(DataGridView dgv, string target) {
			if (target.CompareTo("") != 0) {
				foreach (DataGridViewRow row in dgv.Rows) {
					row.Selected = false;
					if (row.Cells[0].Value.ToString().CompareTo(target) == 0) row.Selected = true;
				}
			}
		}

		private void NewProject(DataGridView dgv, ProjectListManager manager) {
			NewProjectForm frm = new NewProjectForm();
			if (frm.ShowDialog() == DialogResult.OK) {
				Project p = new Project(frm.ProjectName);
				p.Notes.Add(new Note("Created", DateTime.Now));
				manager.Add(p);								
				LoadDataViewGrid(dgv, manager);
				SelectRow(dgv, p.Name);
			}
		}

		private void MoveProject(string ProjectName, DataGridView fromdgv, ProjectListManager from, 
			DataGridView todgv, ProjectListManager to) {
			Project mover = from.Find(ProjectName);
			from.Remove(mover);				
			to.Add(mover);
			LoadDataViewGrid(fromdgv, from);
			LoadDataViewGrid(todgv, to);
		}

		private void ShowNotes(DataGridView dgv) {
			if (dgv.SelectedRows.Count == 0) return;
			DataGridViewRow row = dgv.SelectedRows[0];
			Project proj = dgv2plm[dgv].ProjectList.Find(delegate(Project p) { return p.Name.CompareTo(row.Cells[0].Value.ToString()) == 0; });
			ShowNotesForm frm = new ShowNotesForm();
			frm.MyProject = proj;
			frm.ShowDialog();
			LoadDataViewGrid(dgv, dgv2plm[dgv]);
		}
		private void Up(DataGridView dgv) {
			if (dgv.SelectedRows.Count == 0) return;
			DataGridViewRow row = dgv.SelectedRows[0];
			DataGridView dgvTo = (dgv == dgvArchive) ? dgvWaiting : dgvActive;
			MoveProject(
				row.Cells[0].Value.ToString(),
				dgv,
				dgv2plm[dgv],
				dgvTo,
				dgv2plm[dgvTo]);
		}
		private void Down(DataGridView dgv) {
			if (dgv.SelectedRows.Count == 0) return;
			DataGridViewRow row = dgv.SelectedRows[0];
			DataGridView dgvTo = (dgv == dgvActive) ? dgvWaiting : dgvArchive;
			MoveProject(
				row.Cells[0].Value.ToString(),
				dgv,
				dgv2plm[dgv],
				dgvTo,
				dgv2plm[dgvTo]);
		}
		#endregion

		#region Timer Tick
		private void timer1_Tick(object sender, EventArgs e) {
			//save the files
			ProjectListManager.WriteFile(Active);
			ProjectListManager.WriteFile(Waiting);
			ProjectListManager.WriteFile(Archive);
		}
		#endregion

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			timer1_Tick(this, EventArgs.Empty);
		}
		private void bimExit_Click(object sender, EventArgs e) {
			this.Close();
		}
		private void biMenuAbout_Click(object sender, EventArgs e) {
			AboutForm frm = new AboutForm();
			frm.ShowDialog();
		}

		#region Form Minimization
		private void notifyIcon1_Click(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				this.Visible = true;
				this.notifyIcon1.Visible = false;
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void frmMain_SizeChanged(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				this.Visible = false;
				notifyIcon1.Visible = true;
			}
		}
		#endregion

		private void dgvActive_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { ShowNotes(dgvActive); }
		private void dgvWaiting_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { ShowNotes(dgvWaiting); }
		private void dgvArchive_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { ShowNotes(dgvArchive); }

		private void biMMExportToXML_Click(object sender, EventArgs e) {
			SaveFileDialog save = new SaveFileDialog();
			save.DefaultExt = ".xml";
			save.Filter = "XML | *.xml";
			save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if (save.ShowDialog() == DialogResult.OK) {
				ProjectListManager[] managers = new ProjectListManager[3];				
				XMLExport.SaveToXML(save.FileName, Active, Waiting, Archive);
			}
		}
		private void biMMExportToExcel_Click(object sender, EventArgs e) {
			SaveFileDialog save = new SaveFileDialog();
			save.DefaultExt = ".txt";
			save.Filter = "Text (tab-delimited) | *.txt";
			save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if (save.ShowDialog() == DialogResult.OK) {
				ProjectListManager[] managers = new ProjectListManager[3];
				TXTExport.SaveToTXT(save.FileName, Active, Waiting, Archive);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			
		}
		private void biTBSearch_Click(object sender, EventArgs e) {
			if (txtTBSearch.ControlText.Length == 0) return;
			List<ProjectListManager> managers = new List<ProjectListManager>();
			managers.Add(Active);
			managers.Add(Waiting);
			managers.Add(Archive);
			SortedList<SearchRank, Project> lst = Search.SearchAll(managers, txtTBSearch.ControlText);
			SearchResultsForm frm = new SearchResultsForm();
			frm.Results = lst;
			frm.Highlighted = txtTBSearch.ControlText;
			frm.ShowDialog();
			//set the focus back?
			txtTBSearch.Focus();
		}

		private void txtTBSearch_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == '\r') { 
				biTBSearch_Click(this, EventArgs.Empty);
				e.Handled = true;
			}
		}		
	}
}