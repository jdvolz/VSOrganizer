namespace VSOrganizer {
	partial class SearchResultsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultsForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDone = new System.Windows.Forms.Button();
			this.dgvActive = new System.Windows.Forms.DataGridView();
			this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.panel1.Controls.Add(this.btnDone);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 366);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 57);
			this.panel1.TabIndex = 2;
			// 
			// btnDone
			// 
			this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDone.BackColor = System.Drawing.Color.White;
			this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDone.Location = new System.Drawing.Point(641, 17);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(75, 23);
			this.btnDone.TabIndex = 0;
			this.btnDone.Text = "&Done";
			this.btnDone.UseVisualStyleBackColor = false;
			// 
			// dgvActive
			// 
			this.dgvActive.AllowUserToAddRows = false;
			this.dgvActive.AllowUserToDeleteRows = false;
			this.dgvActive.BackgroundColor = System.Drawing.Color.White;
			this.dgvActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.LastNote});
			this.dgvActive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvActive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvActive.GridColor = System.Drawing.Color.Black;
			this.dgvActive.Location = new System.Drawing.Point(0, 0);
			this.dgvActive.MultiSelect = false;
			this.dgvActive.Name = "dgvActive";
			this.dgvActive.ReadOnly = true;
			this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvActive.Size = new System.Drawing.Size(728, 366);
			this.dgvActive.TabIndex = 0;
			this.dgvActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvActive_KeyDown);
			this.dgvActive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActive_CellDoubleClick);
			// 
			// ProjectName
			// 
			this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProjectName.HeaderText = "Project Name";
			this.ProjectName.Name = "ProjectName";
			this.ProjectName.ReadOnly = true;
			this.ProjectName.Width = 96;
			// 
			// LastNote
			// 
			this.LastNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LastNote.HeaderText = "Last Note";
			this.LastNote.Name = "LastNote";
			this.LastNote.ReadOnly = true;
			// 
			// SearchResultsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnDone;
			this.ClientSize = new System.Drawing.Size(728, 423);
			this.Controls.Add(this.dgvActive);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchResultsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SearchResultsForm";
			this.Load += new System.EventHandler(this.SearchResultsForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.DataGridView dgvActive;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastNote;
	}
}