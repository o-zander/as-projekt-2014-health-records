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
            this.illnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.createBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.matchBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 332);
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 326);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 137);
            this.dataGridView1.TabIndex = 0;       
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "ID";
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
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(HealthRecords.Patient);
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.DataSource = this.illnessBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 186);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(564, 137);
            this.dataGridView2.TabIndex = 1;
            // 
            // illnessIDDataGridViewTextBoxColumn
            // 
            this.illnessIDDataGridViewTextBoxColumn.DataPropertyName = "IllnessID";
            this.illnessIDDataGridViewTextBoxColumn.HeaderText = "IllnessID";
            this.illnessIDDataGridViewTextBoxColumn.Name = "illnessIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contagiousDataGridViewCheckBoxColumn
            // 
            this.contagiousDataGridViewCheckBoxColumn.DataPropertyName = "Contagious";
            this.contagiousDataGridViewCheckBoxColumn.HeaderText = "Contagious";
            this.contagiousDataGridViewCheckBoxColumn.Name = "contagiousDataGridViewCheckBoxColumn";
            // 
            // lethalDataGridViewCheckBoxColumn
            // 
            this.lethalDataGridViewCheckBoxColumn.DataPropertyName = "Lethal";
            this.lethalDataGridViewCheckBoxColumn.HeaderText = "Lethal";
            this.lethalDataGridViewCheckBoxColumn.Name = "lethalDataGridViewCheckBoxColumn";
            // 
            // curableDataGridViewCheckBoxColumn
            // 
            this.curableDataGridViewCheckBoxColumn.DataPropertyName = "Curable";
            this.curableDataGridViewCheckBoxColumn.HeaderText = "Curable";
            this.curableDataGridViewCheckBoxColumn.Name = "curableDataGridViewCheckBoxColumn";
            // 
            // illnessBindingSource
            // 
            this.illnessBindingSource.DataSource = typeof(HealthRecords.Illness);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.createBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.matchBtn, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 146);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // createBtn
            // 
            this.createBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createBtn.Location = new System.Drawing.Point(3, 3);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(135, 28);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Erstellen";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.Location = new System.Drawing.Point(144, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(135, 28);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Bearbeiten";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(285, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(135, 28);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Löschen";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // matchBtn
            // 
            this.matchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchBtn.Location = new System.Drawing.Point(426, 3);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(135, 28);
            this.matchBtn.TabIndex = 3;
            this.matchBtn.Text = "Zuordnen";
            this.matchBtn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Krankheiten";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.illnessBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
    private System.Windows.Forms.DataGridViewTextBoxColumn illnessIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn contagiousDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn lethalDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn curableDataGridViewCheckBoxColumn;
    private System.Windows.Forms.BindingSource illnessBindingSource;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button createBtn;
    private System.Windows.Forms.Button editBtn;
    private System.Windows.Forms.Button deleteBtn;
    private System.Windows.Forms.Button matchBtn;
    private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
  }
}

