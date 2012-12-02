namespace VSOrganizer {
	partial class frmMain {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.dgvActive = new System.Windows.Forms.DataGridView();
			this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.btnActiveNew = new System.Windows.Forms.Button();
			this.btnActiveDown = new System.Windows.Forms.Button();
			this.btnActiveNotes = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.btnWaitingNew = new System.Windows.Forms.Button();
			this.dgvWaiting = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnWaitingUp = new System.Windows.Forms.Button();
			this.btnWaitingNotes = new System.Windows.Forms.Button();
			this.btnWaitingDown = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnArchiveNew = new System.Windows.Forms.Button();
			this.dgvArchive = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnArchiveUp = new System.Windows.Forms.Button();
			this.btnArchiveNotes = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite8 = new DevComponents.DotNetBar.DockSite();
			this.dockSite5 = new DevComponents.DotNetBar.DockSite();
			this.dockSite6 = new DevComponents.DotNetBar.DockSite();
			this.dockSite7 = new DevComponents.DotNetBar.DockSite();
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.biMMExportToXML = new DevComponents.DotNetBar.ButtonItem();
			this.biMMExportToTXT = new DevComponents.DotNetBar.ButtonItem();
			this.bimExit = new DevComponents.DotNetBar.ButtonItem();
			this.biMenuHelp = new DevComponents.DotNetBar.ButtonItem();
			this.biMenuAbout = new DevComponents.DotNetBar.ButtonItem();
			this.ToolBar = new DevComponents.DotNetBar.Bar();
			this.txtTBSearch = new DevComponents.DotNetBar.TextBoxItem();
			this.biTBSearch = new DevComponents.DotNetBar.ButtonItem();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvWaiting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
			this.dockSite7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ToolBar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvActive
			// 
			this.dgvActive.AllowUserToAddRows = false;
			this.dgvActive.AllowUserToDeleteRows = false;
			this.dgvActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvActive.BackgroundColor = System.Drawing.Color.White;
			this.dgvActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.LastNote});
			this.dgvActive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvActive.GridColor = System.Drawing.Color.Black;
			this.dgvActive.Location = new System.Drawing.Point(3, 22);
			this.dgvActive.MultiSelect = false;
			this.dgvActive.Name = "dgvActive";
			this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvActive.Size = new System.Drawing.Size(789, 127);
			this.dgvActive.TabIndex = 2;
			this.dgvActive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActive_CellDoubleClick);
			// 
			// ProjectName
			// 
			this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProjectName.HeaderText = "Project Name";
			this.ProjectName.Name = "ProjectName";
			this.ProjectName.Width = 96;
			// 
			// LastNote
			// 
			this.LastNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LastNote.HeaderText = "Last Note";
			this.LastNote.Name = "LastNote";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 50);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.btnActiveNew);
			this.splitContainer1.Panel1.Controls.Add(this.dgvActive);
			this.splitContainer1.Panel1.Controls.Add(this.btnActiveDown);
			this.splitContainer1.Panel1.Controls.Add(this.btnActiveNotes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(792, 536);
			this.splitContainer1.SplitterDistance = 175;
			this.splitContainer1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Active";
			// 
			// btnActiveNew
			// 
			this.btnActiveNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnActiveNew.BackColor = System.Drawing.Color.White;
			this.btnActiveNew.Location = new System.Drawing.Point(165, 150);
			this.btnActiveNew.Name = "btnActiveNew";
			this.btnActiveNew.Size = new System.Drawing.Size(75, 23);
			this.btnActiveNew.TabIndex = 5;
			this.btnActiveNew.Text = "New";
			this.toolTip1.SetToolTip(this.btnActiveNew, "Create a new project");
			this.btnActiveNew.UseVisualStyleBackColor = false;
			this.btnActiveNew.Click += new System.EventHandler(this.btnActiveNew_Click);
			// 
			// btnActiveDown
			// 
			this.btnActiveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnActiveDown.BackColor = System.Drawing.Color.White;
			this.btnActiveDown.Image = global::VSOrganizer.Properties.Resources.arrow_down_green1;
			this.btnActiveDown.Location = new System.Drawing.Point(3, 150);
			this.btnActiveDown.Name = "btnActiveDown";
			this.btnActiveDown.Size = new System.Drawing.Size(75, 23);
			this.btnActiveDown.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnActiveDown, "Move the selected project to Waiting");
			this.btnActiveDown.UseVisualStyleBackColor = false;
			this.btnActiveDown.Click += new System.EventHandler(this.btnActiveDown_Click);
			// 
			// btnActiveNotes
			// 
			this.btnActiveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnActiveNotes.BackColor = System.Drawing.Color.White;
			this.btnActiveNotes.Image = global::VSOrganizer.Properties.Resources.document_text;
			this.btnActiveNotes.Location = new System.Drawing.Point(84, 150);
			this.btnActiveNotes.Name = "btnActiveNotes";
			this.btnActiveNotes.Size = new System.Drawing.Size(75, 23);
			this.btnActiveNotes.TabIndex = 4;
			this.toolTip1.SetToolTip(this.btnActiveNotes, "View notes for selected project");
			this.btnActiveNotes.UseVisualStyleBackColor = false;
			this.btnActiveNotes.Click += new System.EventHandler(this.btnActiveNotes_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.btnWaitingNew);
			this.splitContainer2.Panel1.Controls.Add(this.dgvWaiting);
			this.splitContainer2.Panel1.Controls.Add(this.btnWaitingUp);
			this.splitContainer2.Panel1.Controls.Add(this.btnWaitingNotes);
			this.splitContainer2.Panel1.Controls.Add(this.btnWaitingDown);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label3);
			this.splitContainer2.Panel2.Controls.Add(this.btnArchiveNew);
			this.splitContainer2.Panel2.Controls.Add(this.dgvArchive);
			this.splitContainer2.Panel2.Controls.Add(this.btnArchiveUp);
			this.splitContainer2.Panel2.Controls.Add(this.btnArchiveNotes);
			this.splitContainer2.Size = new System.Drawing.Size(792, 357);
			this.splitContainer2.SplitterDistance = 177;
			this.splitContainer2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Waiting";
			// 
			// btnWaitingNew
			// 
			this.btnWaitingNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWaitingNew.BackColor = System.Drawing.Color.White;
			this.btnWaitingNew.Location = new System.Drawing.Point(246, 151);
			this.btnWaitingNew.Name = "btnWaitingNew";
			this.btnWaitingNew.Size = new System.Drawing.Size(75, 23);
			this.btnWaitingNew.TabIndex = 4;
			this.btnWaitingNew.Text = "New";
			this.toolTip1.SetToolTip(this.btnWaitingNew, "Create a new project");
			this.btnWaitingNew.UseVisualStyleBackColor = false;
			this.btnWaitingNew.Click += new System.EventHandler(this.btnWaitingNew_Click);
			// 
			// dgvWaiting
			// 
			this.dgvWaiting.AllowUserToAddRows = false;
			this.dgvWaiting.AllowUserToDeleteRows = false;
			this.dgvWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvWaiting.BackgroundColor = System.Drawing.Color.White;
			this.dgvWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWaiting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dgvWaiting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvWaiting.GridColor = System.Drawing.Color.Black;
			this.dgvWaiting.Location = new System.Drawing.Point(3, 29);
			this.dgvWaiting.MultiSelect = false;
			this.dgvWaiting.Name = "dgvWaiting";
			this.dgvWaiting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWaiting.Size = new System.Drawing.Size(789, 122);
			this.dgvWaiting.TabIndex = 0;
			this.dgvWaiting.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaiting_CellDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.HeaderText = "Project Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 96;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Last Note";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// btnWaitingUp
			// 
			this.btnWaitingUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWaitingUp.BackColor = System.Drawing.Color.White;
			this.btnWaitingUp.Image = global::VSOrganizer.Properties.Resources.arrow_up_green;
			this.btnWaitingUp.Location = new System.Drawing.Point(3, 151);
			this.btnWaitingUp.Name = "btnWaitingUp";
			this.btnWaitingUp.Size = new System.Drawing.Size(75, 23);
			this.btnWaitingUp.TabIndex = 1;
			this.toolTip1.SetToolTip(this.btnWaitingUp, "Move the selected project to Active");
			this.btnWaitingUp.UseVisualStyleBackColor = false;
			this.btnWaitingUp.Click += new System.EventHandler(this.btnWaitingUp_Click);
			// 
			// btnWaitingNotes
			// 
			this.btnWaitingNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWaitingNotes.BackColor = System.Drawing.Color.White;
			this.btnWaitingNotes.Image = global::VSOrganizer.Properties.Resources.document_text;
			this.btnWaitingNotes.Location = new System.Drawing.Point(165, 151);
			this.btnWaitingNotes.Name = "btnWaitingNotes";
			this.btnWaitingNotes.Size = new System.Drawing.Size(75, 23);
			this.btnWaitingNotes.TabIndex = 3;
			this.toolTip1.SetToolTip(this.btnWaitingNotes, "View notes for selected project");
			this.btnWaitingNotes.UseVisualStyleBackColor = false;
			this.btnWaitingNotes.Click += new System.EventHandler(this.btnWaitingNotes_Click);
			// 
			// btnWaitingDown
			// 
			this.btnWaitingDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnWaitingDown.BackColor = System.Drawing.Color.White;
			this.btnWaitingDown.Image = global::VSOrganizer.Properties.Resources.arrow_down_green1;
			this.btnWaitingDown.Location = new System.Drawing.Point(84, 151);
			this.btnWaitingDown.Name = "btnWaitingDown";
			this.btnWaitingDown.Size = new System.Drawing.Size(75, 23);
			this.btnWaitingDown.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnWaitingDown, "Move the selected project to Archived");
			this.btnWaitingDown.UseVisualStyleBackColor = false;
			this.btnWaitingDown.Click += new System.EventHandler(this.btnWaitingDown_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(3, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Archived";
			// 
			// btnArchiveNew
			// 
			this.btnArchiveNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnArchiveNew.BackColor = System.Drawing.Color.White;
			this.btnArchiveNew.Location = new System.Drawing.Point(165, 151);
			this.btnArchiveNew.Name = "btnArchiveNew";
			this.btnArchiveNew.Size = new System.Drawing.Size(75, 23);
			this.btnArchiveNew.TabIndex = 3;
			this.btnArchiveNew.Text = "New";
			this.toolTip1.SetToolTip(this.btnArchiveNew, "Create a new project");
			this.btnArchiveNew.UseVisualStyleBackColor = false;
			this.btnArchiveNew.Click += new System.EventHandler(this.btnArchiveNew_Click);
			// 
			// dgvArchive
			// 
			this.dgvArchive.AllowUserToAddRows = false;
			this.dgvArchive.AllowUserToDeleteRows = false;
			this.dgvArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvArchive.BackgroundColor = System.Drawing.Color.White;
			this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dgvArchive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvArchive.GridColor = System.Drawing.Color.Black;
			this.dgvArchive.Location = new System.Drawing.Point(3, 26);
			this.dgvArchive.MultiSelect = false;
			this.dgvArchive.Name = "dgvArchive";
			this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArchive.Size = new System.Drawing.Size(789, 125);
			this.dgvArchive.TabIndex = 0;
			this.dgvArchive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchive_CellDoubleClick);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.HeaderText = "Project Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 96;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "Last Note";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// btnArchiveUp
			// 
			this.btnArchiveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnArchiveUp.BackColor = System.Drawing.Color.White;
			this.btnArchiveUp.Image = global::VSOrganizer.Properties.Resources.arrow_up_green;
			this.btnArchiveUp.Location = new System.Drawing.Point(2, 151);
			this.btnArchiveUp.Name = "btnArchiveUp";
			this.btnArchiveUp.Size = new System.Drawing.Size(75, 23);
			this.btnArchiveUp.TabIndex = 1;
			this.toolTip1.SetToolTip(this.btnArchiveUp, "Move the selected project to Waiting");
			this.btnArchiveUp.UseVisualStyleBackColor = false;
			this.btnArchiveUp.Click += new System.EventHandler(this.btnArchiveUp_Click);
			// 
			// btnArchiveNotes
			// 
			this.btnArchiveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnArchiveNotes.BackColor = System.Drawing.Color.White;
			this.btnArchiveNotes.Image = global::VSOrganizer.Properties.Resources.document_text;
			this.btnArchiveNotes.Location = new System.Drawing.Point(84, 151);
			this.btnArchiveNotes.Name = "btnArchiveNotes";
			this.btnArchiveNotes.Size = new System.Drawing.Size(75, 23);
			this.btnArchiveNotes.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnArchiveNotes, "View notes for selected project");
			this.btnArchiveNotes.UseVisualStyleBackColor = false;
			this.btnArchiveNotes.Click += new System.EventHandler(this.btnArchiveNotes_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 60000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dotNetBarManager1
			// 
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
			this.dotNetBarManager1.BottomDockSite = this.dockSite4;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.EnableFullSizeDock = false;
			this.dotNetBarManager1.LeftDockSite = this.dockSite1;
			this.dotNetBarManager1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.dockSite2;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
			this.dotNetBarManager1.TopDockSite = this.dockSite3;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite4.Location = new System.Drawing.Point(0, 586);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(792, 0);
			this.dockSite4.TabIndex = 9;
			this.dockSite4.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite1.Location = new System.Drawing.Point(0, 50);
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 536);
			this.dockSite1.TabIndex = 6;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite2.Location = new System.Drawing.Point(792, 50);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 536);
			this.dockSite2.TabIndex = 7;
			this.dockSite2.TabStop = false;
			// 
			// dockSite8
			// 
			this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite8.Location = new System.Drawing.Point(0, 586);
			this.dockSite8.Name = "dockSite8";
			this.dockSite8.Size = new System.Drawing.Size(792, 0);
			this.dockSite8.TabIndex = 13;
			this.dockSite8.TabStop = false;
			// 
			// dockSite5
			// 
			this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite5.Location = new System.Drawing.Point(0, 50);
			this.dockSite5.Name = "dockSite5";
			this.dockSite5.Size = new System.Drawing.Size(0, 536);
			this.dockSite5.TabIndex = 10;
			this.dockSite5.TabStop = false;
			// 
			// dockSite6
			// 
			this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite6.Location = new System.Drawing.Point(792, 50);
			this.dockSite6.Name = "dockSite6";
			this.dockSite6.Size = new System.Drawing.Size(0, 536);
			this.dockSite6.TabIndex = 11;
			this.dockSite6.TabStop = false;
			// 
			// dockSite7
			// 
			this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.dockSite7.Controls.Add(this.bar1);
			this.dockSite7.Controls.Add(this.ToolBar);
			this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite7.Location = new System.Drawing.Point(0, 0);
			this.dockSite7.Name = "dockSite7";
			this.dockSite7.Size = new System.Drawing.Size(792, 50);
			this.dockSite7.TabIndex = 0;
			this.dockSite7.TabStop = false;
			// 
			// bar1
			// 
			this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
			this.bar1.AccessibleName = "DotNetBar Bar";
			this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarCaptionBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarCaptionBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarDockedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.BarFloatingBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemCheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.bar1.ColorScheme.ItemCheckedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.bar1.ColorScheme.ItemCheckedText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar1.ColorScheme.ItemExpandedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemExpandedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemExpandedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.ItemExpandedText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar1.ColorScheme.ItemHotBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.bar1.ColorScheme.ItemHotBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.bar1.ColorScheme.ItemHotText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.bar1.ColorScheme.ItemPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.bar1.ColorScheme.ItemPressedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.bar1.ColorScheme.ItemPressedText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar1.ColorScheme.ItemText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bar1.ColorScheme.MenuBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.bar1.ColorScheme.MenuBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.MenuSide = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.bar1.ColorScheme.MenuSide2 = System.Drawing.Color.White;
			this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.bar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.biMenuHelp});
			this.bar1.Location = new System.Drawing.Point(0, 0);
			this.bar1.MenuBar = true;
			this.bar1.Name = "bar1";
			this.bar1.Size = new System.Drawing.Size(792, 24);
			this.bar1.Stretch = true;
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			// 
			// buttonItem1
			// 
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.bimExit});
			this.buttonItem1.Text = "&File";
			// 
			// buttonItem2
			// 
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biMMExportToXML,
            this.biMMExportToTXT});
			this.buttonItem2.Text = "Export";
			// 
			// biMMExportToXML
			// 
			this.biMMExportToXML.Name = "biMMExportToXML";
			this.biMMExportToXML.Text = "To XML";
			this.biMMExportToXML.Click += new System.EventHandler(this.biMMExportToXML_Click);
			// 
			// biMMExportToTXT
			// 
			this.biMMExportToTXT.Name = "biMMExportToTXT";
			this.biMMExportToTXT.Text = "To TXT";
			this.biMMExportToTXT.Click += new System.EventHandler(this.biMMExportToExcel_Click);
			// 
			// bimExit
			// 
			this.bimExit.ForeColor = System.Drawing.Color.White;
			this.bimExit.Name = "bimExit";
			this.bimExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
			this.bimExit.Text = "Exit";
			this.bimExit.Click += new System.EventHandler(this.bimExit_Click);
			// 
			// biMenuHelp
			// 
			this.biMenuHelp.Name = "biMenuHelp";
			this.biMenuHelp.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biMenuAbout});
			this.biMenuHelp.Text = "Help";
			// 
			// biMenuAbout
			// 
			this.biMenuAbout.Name = "biMenuAbout";
			this.biMenuAbout.Text = "About";
			this.biMenuAbout.Click += new System.EventHandler(this.biMenuAbout_Click);
			// 
			// ToolBar
			// 
			this.ToolBar.AccessibleDescription = "DotNetBar Bar (ToolBar)";
			this.ToolBar.AccessibleName = "DotNetBar Bar";
			this.ToolBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.ToolBar.ColorScheme.BarBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarCaptionBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarCaptionBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarCaptionInactiveBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarCaptionInactiveBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarDockedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarFloatingBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.BarPopupBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.CustomizeBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.CustomizeBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.CustomizeText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.ToolBar.ColorScheme.DockSiteBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.DockSiteBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.ItemCheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.ToolBar.ColorScheme.ItemCheckedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.ToolBar.ColorScheme.ItemHotBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.ToolBar.ColorScheme.ItemHotBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.ToolBar.ColorScheme.ItemHotText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ToolBar.ColorScheme.ItemPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(255)))), ((int)(((byte)(47)))));
			this.ToolBar.ColorScheme.ItemPressedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
			this.ToolBar.ColorScheme.ItemText = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ToolBar.ColorScheme.PanelBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.PanelBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.ColorScheme.PanelBorder = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ToolBar.DockLine = 1;
			this.ToolBar.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.ToolBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
			this.ToolBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.txtTBSearch,
            this.biTBSearch});
			this.ToolBar.Location = new System.Drawing.Point(0, 25);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Padding = new System.Windows.Forms.Padding(3);
			this.ToolBar.Size = new System.Drawing.Size(257, 25);
			this.ToolBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.ToolBar.TabIndex = 1;
			this.ToolBar.TabStop = false;
			this.ToolBar.Text = "bar2";
			// 
			// txtTBSearch
			// 
			this.txtTBSearch.AlwaysShowCaption = false;
			this.txtTBSearch.ControlText = "";
			this.txtTBSearch.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.txtTBSearch.Name = "txtTBSearch";
			this.txtTBSearch.RecentlyUsed = false;
			this.txtTBSearch.SelectedText = "";
			this.txtTBSearch.SelectionLength = 0;
			this.txtTBSearch.SelectionStart = 0;
			this.txtTBSearch.TextBoxWidth = 200;
			this.txtTBSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTBSearch_KeyPress);
			// 
			// biTBSearch
			// 
			this.biTBSearch.FontBold = true;
			this.biTBSearch.Name = "biTBSearch";
			this.biTBSearch.Text = "Search";
			this.biTBSearch.Click += new System.EventHandler(this.biTBSearch_Click);
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite3.Location = new System.Drawing.Point(0, 50);
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(792, 0);
			this.dockSite3.TabIndex = 8;
			this.dockSite3.TabStop = false;
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Vizonware Organizer";
			this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
			this.ClientSize = new System.Drawing.Size(792, 586);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.dockSite1);
			this.Controls.Add(this.dockSite2);
			this.Controls.Add(this.dockSite3);
			this.Controls.Add(this.dockSite4);
			this.Controls.Add(this.dockSite5);
			this.Controls.Add(this.dockSite6);
			this.Controls.Add(this.dockSite7);
			this.Controls.Add(this.dockSite8);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "Vizonware Organizer";
			this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvWaiting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
			this.dockSite7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ToolBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvActive;
		private System.Windows.Forms.Button btnActiveDown;
		private System.Windows.Forms.Button btnActiveNotes;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dgvWaiting;
		private System.Windows.Forms.Button btnWaitingUp;
		private System.Windows.Forms.Button btnWaitingNotes;
		private System.Windows.Forms.Button btnWaitingDown;
		private System.Windows.Forms.DataGridView dgvArchive;
		private System.Windows.Forms.Button btnArchiveUp;
		private System.Windows.Forms.Button btnArchiveNotes;
		private System.Windows.Forms.Button btnActiveNew;
		private System.Windows.Forms.Button btnWaitingNew;
		private System.Windows.Forms.Button btnArchiveNew;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite5;
		private DevComponents.DotNetBar.DockSite dockSite6;
		private DevComponents.DotNetBar.DockSite dockSite7;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem bimExit;
		private DevComponents.DotNetBar.DockSite dockSite8;
		private DevComponents.DotNetBar.ButtonItem biMenuHelp;
		private DevComponents.DotNetBar.ButtonItem biMenuAbout;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastNote;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem biMMExportToXML;
		private DevComponents.DotNetBar.ButtonItem biMMExportToTXT;
		private DevComponents.DotNetBar.Bar ToolBar;
		private DevComponents.DotNetBar.TextBoxItem txtTBSearch;
		private DevComponents.DotNetBar.ButtonItem biTBSearch;
	}
}

