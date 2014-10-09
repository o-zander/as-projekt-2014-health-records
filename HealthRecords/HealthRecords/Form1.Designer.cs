namespace HealthRecords
{
  partial class OverviewForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.illnessIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contagiousDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lethalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.curableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.illnessContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelIllnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAllIllnessesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingIllnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBtnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.createPatientBtn = new System.Windows.Forms.Button();
            this.editPatientBtn = new System.Windows.Forms.Button();
            this.deletePatientBtn = new System.Windows.Forms.Button();
            this.matchPatientBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.illnessBtnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.createIllnessBtn = new System.Windows.Forms.Button();
            this.editIllnessBtn = new System.Windows.Forms.Button();
            this.deleteIllnessBtn = new System.Windows.Forms.Button();
            this.matchIllnessBtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.illnessIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contagiousDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lethalDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.curableDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.illnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAllPatientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.illnessContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchingIllnessBindingSource)).BeginInit();
            this.patientBtnTableLayoutPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.illnessBtnTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.patientContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchingPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patienten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientBtnTableLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 329);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "geboren am";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(HealthRecords.Patient);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.illnessIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contagiousDataGridViewCheckBoxColumn,
            this.lethalDataGridViewCheckBoxColumn,
            this.curableDataGridViewCheckBoxColumn});
            this.dataGridView2.ContextMenuStrip = this.illnessContextMenuStrip;
            this.dataGridView2.DataSource = this.matchingIllnessBindingSource;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 187);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(564, 139);
            this.dataGridView2.TabIndex = 1;
            // 
            // illnessIDDataGridViewTextBoxColumn
            // 
            this.illnessIDDataGridViewTextBoxColumn.DataPropertyName = "IllnessID";
            this.illnessIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.illnessIDDataGridViewTextBoxColumn.HeaderText = "Krankheit ID";
            this.illnessIDDataGridViewTextBoxColumn.Name = "illnessIDDataGridViewTextBoxColumn";
            this.illnessIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contagiousDataGridViewCheckBoxColumn
            // 
            this.contagiousDataGridViewCheckBoxColumn.DataPropertyName = "Contagious";
            this.contagiousDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.contagiousDataGridViewCheckBoxColumn.HeaderText = "Ansteckend";
            this.contagiousDataGridViewCheckBoxColumn.Name = "contagiousDataGridViewCheckBoxColumn";
            this.contagiousDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lethalDataGridViewCheckBoxColumn
            // 
            this.lethalDataGridViewCheckBoxColumn.DataPropertyName = "Lethal";
            this.lethalDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.lethalDataGridViewCheckBoxColumn.HeaderText = "Tödlich";
            this.lethalDataGridViewCheckBoxColumn.Name = "lethalDataGridViewCheckBoxColumn";
            this.lethalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // curableDataGridViewCheckBoxColumn
            // 
            this.curableDataGridViewCheckBoxColumn.DataPropertyName = "Curable";
            this.curableDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.curableDataGridViewCheckBoxColumn.HeaderText = "Heilbar";
            this.curableDataGridViewCheckBoxColumn.Name = "curableDataGridViewCheckBoxColumn";
            this.curableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // illnessContextMenuStrip
            // 
            this.illnessContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelIllnessMenuItem,
            this.cancelAllIllnessesMenuItem});
            this.illnessContextMenuStrip.Name = "illnessContextMenuStrip";
            this.illnessContextMenuStrip.Size = new System.Drawing.Size(214, 48);
            // 
            // cancelIllnessMenuItem
            // 
            this.cancelIllnessMenuItem.Name = "cancelIllnessMenuItem";
            this.cancelIllnessMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cancelIllnessMenuItem.Text = "Krankheit austragen";
            this.cancelIllnessMenuItem.Click += new System.EventHandler(this.cancelIllnessMenuItem_Click);
            // 
            // cancelAllIllnessesMenuItem
            // 
            this.cancelAllIllnessesMenuItem.Name = "cancelAllIllnessesMenuItem";
            this.cancelAllIllnessesMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cancelAllIllnessesMenuItem.Text = "alle Krankheiten austragen";
            this.cancelAllIllnessesMenuItem.Click += new System.EventHandler(this.cancelAllIllnessesMenuItem_Click);
            // 
            // matchingIllnessBindingSource
            // 
            this.matchingIllnessBindingSource.DataSource = typeof(HealthRecords.Illness);
            // 
            // patientBtnTableLayoutPanel
            // 
            this.patientBtnTableLayoutPanel.ColumnCount = 4;
            this.patientBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.patientBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.patientBtnTableLayoutPanel.Controls.Add(this.createPatientBtn, 0, 0);
            this.patientBtnTableLayoutPanel.Controls.Add(this.editPatientBtn, 1, 0);
            this.patientBtnTableLayoutPanel.Controls.Add(this.deletePatientBtn, 2, 0);
            this.patientBtnTableLayoutPanel.Controls.Add(this.matchPatientBtn, 3, 0);
            this.patientBtnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientBtnTableLayoutPanel.Location = new System.Drawing.Point(3, 147);
            this.patientBtnTableLayoutPanel.Name = "patientBtnTableLayoutPanel";
            this.patientBtnTableLayoutPanel.RowCount = 1;
            this.patientBtnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.patientBtnTableLayoutPanel.Size = new System.Drawing.Size(564, 34);
            this.patientBtnTableLayoutPanel.TabIndex = 2;
            // 
            // createPatientBtn
            // 
            this.createPatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPatientBtn.Location = new System.Drawing.Point(3, 3);
            this.createPatientBtn.Name = "createPatientBtn";
            this.createPatientBtn.Size = new System.Drawing.Size(135, 28);
            this.createPatientBtn.TabIndex = 0;
            this.createPatientBtn.Text = "Pat. erstellen";
            this.createPatientBtn.UseVisualStyleBackColor = true;
            this.createPatientBtn.Click += new System.EventHandler(this.createPatientBtn_Click);
            // 
            // editPatientBtn
            // 
            this.editPatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPatientBtn.Location = new System.Drawing.Point(144, 3);
            this.editPatientBtn.Name = "editPatientBtn";
            this.editPatientBtn.Size = new System.Drawing.Size(135, 28);
            this.editPatientBtn.TabIndex = 1;
            this.editPatientBtn.Text = "Pat. bearbeiten";
            this.editPatientBtn.UseVisualStyleBackColor = true;
            this.editPatientBtn.Click += new System.EventHandler(this.editPatientBtn_Click);
            // 
            // deletePatientBtn
            // 
            this.deletePatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletePatientBtn.Location = new System.Drawing.Point(285, 3);
            this.deletePatientBtn.Name = "deletePatientBtn";
            this.deletePatientBtn.Size = new System.Drawing.Size(135, 28);
            this.deletePatientBtn.TabIndex = 2;
            this.deletePatientBtn.Text = "Pat. löschen";
            this.deletePatientBtn.UseVisualStyleBackColor = true;
            this.deletePatientBtn.Click += new System.EventHandler(this.deletePatientBtn_Click);
            // 
            // matchPatientBtn
            // 
            this.matchPatientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchPatientBtn.Location = new System.Drawing.Point(426, 3);
            this.matchPatientBtn.Name = "matchPatientBtn";
            this.matchPatientBtn.Size = new System.Drawing.Size(135, 28);
            this.matchPatientBtn.TabIndex = 3;
            this.matchPatientBtn.Text = "Krankheit zuordnen";
            this.matchPatientBtn.UseVisualStyleBackColor = true;
            this.matchPatientBtn.Click += new System.EventHandler(this.matchPatientWithIllnessBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Krankheiten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.illnessBtnTableLayoutPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 329);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // illnessBtnTableLayoutPanel
            // 
            this.illnessBtnTableLayoutPanel.ColumnCount = 4;
            this.illnessBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.illnessBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.illnessBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.illnessBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.illnessBtnTableLayoutPanel.Controls.Add(this.createIllnessBtn, 0, 0);
            this.illnessBtnTableLayoutPanel.Controls.Add(this.editIllnessBtn, 1, 0);
            this.illnessBtnTableLayoutPanel.Controls.Add(this.deleteIllnessBtn, 2, 0);
            this.illnessBtnTableLayoutPanel.Controls.Add(this.matchIllnessBtn, 3, 0);
            this.illnessBtnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.illnessBtnTableLayoutPanel.Location = new System.Drawing.Point(3, 147);
            this.illnessBtnTableLayoutPanel.Name = "illnessBtnTableLayoutPanel";
            this.illnessBtnTableLayoutPanel.RowCount = 1;
            this.illnessBtnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.illnessBtnTableLayoutPanel.Size = new System.Drawing.Size(564, 34);
            this.illnessBtnTableLayoutPanel.TabIndex = 0;
            // 
            // createIllnessBtn
            // 
            this.createIllnessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createIllnessBtn.Location = new System.Drawing.Point(3, 3);
            this.createIllnessBtn.Name = "createIllnessBtn";
            this.createIllnessBtn.Size = new System.Drawing.Size(135, 28);
            this.createIllnessBtn.TabIndex = 0;
            this.createIllnessBtn.Text = "Krank. erstellen";
            this.createIllnessBtn.UseVisualStyleBackColor = true;
            this.createIllnessBtn.Click += new System.EventHandler(this.createIllnessBtn_Click);
            // 
            // editIllnessBtn
            // 
            this.editIllnessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editIllnessBtn.Location = new System.Drawing.Point(144, 3);
            this.editIllnessBtn.Name = "editIllnessBtn";
            this.editIllnessBtn.Size = new System.Drawing.Size(135, 28);
            this.editIllnessBtn.TabIndex = 1;
            this.editIllnessBtn.Text = "Krank. bearbeiten";
            this.editIllnessBtn.UseVisualStyleBackColor = true;
            this.editIllnessBtn.Click += new System.EventHandler(this.editIllnessBtn_Click);
            // 
            // deleteIllnessBtn
            // 
            this.deleteIllnessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteIllnessBtn.Location = new System.Drawing.Point(285, 3);
            this.deleteIllnessBtn.Name = "deleteIllnessBtn";
            this.deleteIllnessBtn.Size = new System.Drawing.Size(135, 28);
            this.deleteIllnessBtn.TabIndex = 2;
            this.deleteIllnessBtn.Text = "Krank. löschen";
            this.deleteIllnessBtn.UseVisualStyleBackColor = true;
            this.deleteIllnessBtn.Click += new System.EventHandler(this.deleteIllnessBtn_Click);
            // 
            // matchIllnessBtn
            // 
            this.matchIllnessBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchIllnessBtn.Location = new System.Drawing.Point(426, 3);
            this.matchIllnessBtn.Name = "matchIllnessBtn";
            this.matchIllnessBtn.Size = new System.Drawing.Size(135, 28);
            this.matchIllnessBtn.TabIndex = 3;
            this.matchIllnessBtn.Text = "Patient zuordnen";
            this.matchIllnessBtn.UseVisualStyleBackColor = true;
            this.matchIllnessBtn.Click += new System.EventHandler(this.matchIllnessWithPatientBtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.illnessIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.contagiousDataGridViewCheckBoxColumn1,
            this.lethalDataGridViewCheckBoxColumn1,
            this.curableDataGridViewCheckBoxColumn1});
            this.dataGridView3.DataSource = this.illnessBindingSource;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(564, 138);
            this.dataGridView3.TabIndex = 1;
            // 
            // illnessIDDataGridViewTextBoxColumn1
            // 
            this.illnessIDDataGridViewTextBoxColumn1.DataPropertyName = "IllnessID";
            this.illnessIDDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.illnessIDDataGridViewTextBoxColumn1.HeaderText = "Krankheit ID";
            this.illnessIDDataGridViewTextBoxColumn1.Name = "illnessIDDataGridViewTextBoxColumn1";
            this.illnessIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // contagiousDataGridViewCheckBoxColumn1
            // 
            this.contagiousDataGridViewCheckBoxColumn1.DataPropertyName = "Contagious";
            this.contagiousDataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.contagiousDataGridViewCheckBoxColumn1.HeaderText = "Ansteckend";
            this.contagiousDataGridViewCheckBoxColumn1.Name = "contagiousDataGridViewCheckBoxColumn1";
            // 
            // lethalDataGridViewCheckBoxColumn1
            // 
            this.lethalDataGridViewCheckBoxColumn1.DataPropertyName = "Lethal";
            this.lethalDataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.lethalDataGridViewCheckBoxColumn1.HeaderText = "Tödlich";
            this.lethalDataGridViewCheckBoxColumn1.Name = "lethalDataGridViewCheckBoxColumn1";
            // 
            // curableDataGridViewCheckBoxColumn1
            // 
            this.curableDataGridViewCheckBoxColumn1.DataPropertyName = "Curable";
            this.curableDataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.curableDataGridViewCheckBoxColumn1.HeaderText = "Heilbar";
            this.curableDataGridViewCheckBoxColumn1.Name = "curableDataGridViewCheckBoxColumn1";
            // 
            // illnessBindingSource
            // 
            this.illnessBindingSource.DataSource = typeof(HealthRecords.Illness);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.birthdayDataGridViewTextBoxColumn1});
            this.dataGridView4.ContextMenuStrip = this.patientContextMenuStrip;
            this.dataGridView4.DataSource = this.matchingPatientBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.Location = new System.Drawing.Point(3, 187);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(564, 139);
            this.dataGridView4.TabIndex = 2;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            this.patientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn1
            // 
            this.birthdayDataGridViewTextBoxColumn1.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn1.HeaderText = "geboren am";
            this.birthdayDataGridViewTextBoxColumn1.Name = "birthdayDataGridViewTextBoxColumn1";
            this.birthdayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientContextMenuStrip
            // 
            this.patientContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelPatientMenuItem,
            this.cancelAllPatientsMenuItem});
            this.patientContextMenuStrip.Name = "contextMenuStrip1";
            this.patientContextMenuStrip.Size = new System.Drawing.Size(201, 48);
            // 
            // cancelPatientMenuItem
            // 
            this.cancelPatientMenuItem.Name = "cancelPatientMenuItem";
            this.cancelPatientMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cancelPatientMenuItem.Text = "Patient austragen";
            this.cancelPatientMenuItem.Click += new System.EventHandler(this.cancelPatientMenuItem_Click);
            // 
            // cancelAllPatientsMenuItem
            // 
            this.cancelAllPatientsMenuItem.Name = "cancelAllPatientsMenuItem";
            this.cancelAllPatientsMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cancelAllPatientsMenuItem.Text = "alle Patienten austragen";
            this.cancelAllPatientsMenuItem.Click += new System.EventHandler(this.cancelAllPatientsMenuItem_Click);
            // 
            // matchingPatientBindingSource
            // 
            this.matchingPatientBindingSource.DataSource = typeof(HealthRecords.Patient);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "OverviewForm";
            this.Text = "Krankenakte";
            this.Load += new System.EventHandler(this.OverviewForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.illnessContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchingIllnessBindingSource)).EndInit();
            this.patientBtnTableLayoutPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.illnessBtnTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.patientContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchingPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource patientBindingSource;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.BindingSource illnessBindingSource;
    private System.Windows.Forms.TableLayoutPanel patientBtnTableLayoutPanel;
    private System.Windows.Forms.Button createPatientBtn;
    private System.Windows.Forms.Button editPatientBtn;
    private System.Windows.Forms.Button deletePatientBtn;
    private System.Windows.Forms.Button matchPatientBtn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel illnessBtnTableLayoutPanel;
    private System.Windows.Forms.Button createIllnessBtn;
    private System.Windows.Forms.Button editIllnessBtn;
    private System.Windows.Forms.Button deleteIllnessBtn;
    private System.Windows.Forms.Button matchIllnessBtn;
    private System.Windows.Forms.DataGridView dataGridView3;
    private System.Windows.Forms.BindingSource matchingIllnessBindingSource;
    private System.Windows.Forms.BindingSource matchingPatientBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn illnessIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn contagiousDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn lethalDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn curableDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridView dataGridView4;
    private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn1;
    private System.Windows.Forms.ContextMenuStrip patientContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem cancelPatientMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelAllPatientsMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn illnessIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn contagiousDataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn lethalDataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn curableDataGridViewCheckBoxColumn1;
    private System.Windows.Forms.ContextMenuStrip illnessContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem cancelIllnessMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelAllIllnessesMenuItem;
  }
}

