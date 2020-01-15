namespace Attendence_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Attendence = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.BtnGetValues = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnAddStudents = new MetroFramework.Controls.MetroButton();
            this.BtnAddClass = new MetroFramework.Controls.MetroButton();
            this.BtnClear = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceRecordsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Attendence_System.DataSet1();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SelectDateForClassDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectClassComboBox = new MetroFramework.Controls.MetroComboBox();
            this.classTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Attendence_System.DataSet1();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.classTBLTableAdapter = new Attendence_System.DataSet1TableAdapters.ClassTBLTableAdapter();
            this.attendanceRecordsTBLTableAdapter = new Attendence_System.DataSet1TableAdapters.AttendanceRecordsTBLTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Present = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Absent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Late = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Excuse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnGetValuesInReportSection = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SelectClassComboBoxInReportSection = new MetroFramework.Controls.MetroComboBox();
            this.Attendence.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Attendence
            // 
            this.Attendence.Controls.Add(this.metroTabPage1);
            this.Attendence.Controls.Add(this.metroTabPage2);
            this.Attendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attendence.Location = new System.Drawing.Point(20, 60);
            this.Attendence.Name = "Attendence";
            this.Attendence.SelectedIndex = 1;
            this.Attendence.Size = new System.Drawing.Size(760, 542);
            this.Attendence.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.BtnGetValues);
            this.metroTabPage1.Controls.Add(this.statusStrip1);
            this.metroTabPage1.Controls.Add(this.BtnAddStudents);
            this.metroTabPage1.Controls.Add(this.BtnAddClass);
            this.metroTabPage1.Controls.Add(this.BtnClear);
            this.metroTabPage1.Controls.Add(this.BtnSave);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.SelectDateForClassDatePicker);
            this.metroTabPage1.Controls.Add(this.SelectClassComboBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 503);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attedence";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // BtnGetValues
            // 
            this.BtnGetValues.Location = new System.Drawing.Point(422, 40);
            this.BtnGetValues.Name = "BtnGetValues";
            this.BtnGetValues.Size = new System.Drawing.Size(79, 20);
            this.BtnGetValues.TabIndex = 12;
            this.BtnGetValues.Text = "Get Values";
            this.BtnGetValues.Click += new System.EventHandler(this.BtnGetValues_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.statusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = ":";
            // 
            // statusLabelUser
            // 
            this.statusLabelUser.Name = "statusLabelUser";
            this.statusLabelUser.Size = new System.Drawing.Size(0, 17);
            // 
            // BtnAddStudents
            // 
            this.BtnAddStudents.Location = new System.Drawing.Point(660, 81);
            this.BtnAddStudents.Name = "BtnAddStudents";
            this.BtnAddStudents.Size = new System.Drawing.Size(79, 28);
            this.BtnAddStudents.TabIndex = 10;
            this.BtnAddStudents.Text = "Add Students";
            this.BtnAddStudents.Click += new System.EventHandler(this.BtnAddStudents_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(660, 40);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(79, 28);
            this.BtnAddClass.TabIndex = 9;
            this.BtnAddClass.Text = "Add Class";
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(337, 124);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(79, 28);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(337, 81);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(79, 28);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceRecordsTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 408);
            this.dataGridView1.TabIndex = 6;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // attendanceRecordsTBLBindingSource
            // 
            this.attendanceRecordsTBLBindingSource.DataMember = "AttendanceRecordsTBL";
            this.attendanceRecordsTBLBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(216, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Select Date:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select Class:";
            // 
            // SelectDateForClassDatePicker
            // 
            this.SelectDateForClassDatePicker.Location = new System.Drawing.Point(216, 40);
            this.SelectDateForClassDatePicker.Name = "SelectDateForClassDatePicker";
            this.SelectDateForClassDatePicker.Size = new System.Drawing.Size(200, 20);
            this.SelectDateForClassDatePicker.TabIndex = 3;
            // 
            // SelectClassComboBox
            // 
            this.SelectClassComboBox.DataSource = this.classTBLBindingSource;
            this.SelectClassComboBox.DisplayMember = "ClassName";
            this.SelectClassComboBox.FormattingEnabled = true;
            this.SelectClassComboBox.ItemHeight = 23;
            this.SelectClassComboBox.Location = new System.Drawing.Point(3, 43);
            this.SelectClassComboBox.Name = "SelectClassComboBox";
            this.SelectClassComboBox.Size = new System.Drawing.Size(175, 29);
            this.SelectClassComboBox.TabIndex = 2;
            this.SelectClassComboBox.ValueMember = "ClassId";
            // 
            // classTBLBindingSource
            // 
            this.classTBLBindingSource.DataMember = "ClassTBL";
            this.classTBLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.SelectClassComboBoxInReportSection);
            this.metroTabPage2.Controls.Add(this.dateTimePicker1);
            this.metroTabPage2.Controls.Add(this.BtnGetValuesInReportSection);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.listView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 503);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reports";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // classTBLTableAdapter
            // 
            this.classTBLTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceRecordsTBLTableAdapter
            // 
            this.attendanceRecordsTBLTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student,
            this.Present,
            this.Absent,
            this.Late,
            this.Excuse});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(713, 355);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Student
            // 
            this.Student.Text = "Student";
            this.Student.Width = 149;
            // 
            // Present
            // 
            this.Present.Text = "Present";
            this.Present.Width = 107;
            // 
            // Absent
            // 
            this.Absent.Text = "Absent";
            this.Absent.Width = 98;
            // 
            // Late
            // 
            this.Late.Text = "Late";
            this.Late.Width = 91;
            // 
            // Excuse
            // 
            this.Excuse.Text = "Excuse";
            this.Excuse.Width = 115;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Select Class:";
            // 
            // BtnGetValuesInReportSection
            // 
            this.BtnGetValuesInReportSection.Location = new System.Drawing.Point(542, 19);
            this.BtnGetValuesInReportSection.Name = "BtnGetValuesInReportSection";
            this.BtnGetValuesInReportSection.Size = new System.Drawing.Size(75, 20);
            this.BtnGetValuesInReportSection.TabIndex = 5;
            this.BtnGetValuesInReportSection.Text = "Get Values";
            this.BtnGetValuesInReportSection.Click += new System.EventHandler(this.BtnGetValuesInReportSection_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // SelectClassComboBoxInReportSection
            // 
            this.SelectClassComboBoxInReportSection.DataSource = this.classTBLBindingSource;
            this.SelectClassComboBoxInReportSection.DisplayMember = "ClassName";
            this.SelectClassComboBoxInReportSection.FormattingEnabled = true;
            this.SelectClassComboBoxInReportSection.ItemHeight = 23;
            this.SelectClassComboBoxInReportSection.Location = new System.Drawing.Point(16, 22);
            this.SelectClassComboBoxInReportSection.Name = "SelectClassComboBoxInReportSection";
            this.SelectClassComboBoxInReportSection.Size = new System.Drawing.Size(149, 29);
            this.SelectClassComboBoxInReportSection.TabIndex = 7;
            this.SelectClassComboBoxInReportSection.ValueMember = "ClassId";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.Attendence);
            this.Name = "MainForm";
            this.Text = "Attendence System";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Attendence.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Attendence;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker SelectDateForClassDatePicker;
        private MetroFramework.Controls.MetroComboBox SelectClassComboBox;
        private MetroFramework.Controls.MetroButton BtnAddStudents;
        private MetroFramework.Controls.MetroButton BtnAddClass;
        private MetroFramework.Controls.MetroButton BtnClear;
        private MetroFramework.Controls.MetroButton BtnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUser;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classTBLBindingSource;
        private DataSet1TableAdapters.ClassTBLTableAdapter classTBLTableAdapter;
        private MetroFramework.Controls.MetroButton BtnGetValues;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource attendanceRecordsTBLBindingSource;
        private DataSet1TableAdapters.AttendanceRecordsTBLTableAdapter attendanceRecordsTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroComboBox SelectClassComboBoxInReportSection;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroButton BtnGetValuesInReportSection;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Student;
        private System.Windows.Forms.ColumnHeader Present;
        private System.Windows.Forms.ColumnHeader Absent;
        private System.Windows.Forms.ColumnHeader Late;
        private System.Windows.Forms.ColumnHeader Excuse;
    }
}

