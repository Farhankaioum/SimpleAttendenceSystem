using Attendence_System.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserId { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           



        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                //open login form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.LoginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserId = newLogin.UserId;
                    statusLabelUser.Text = UserId.ToString();
                    loggedIn = 1;

                    // TODO: This line of code loads data into the 'dataSet1.ClassTBL' table. You can move, or remove it, as needed.
                    this.classTBLTableAdapter.Fill(this.dataSet1.ClassTBL);
                    this.classTBLBindingSource.Filter = "UserId = '"+UserId.ToString()+"'";
                }
            }
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            FrmAddClass addClass = new FrmAddClass();
            addClass.UserId = this.UserId;
            addClass.ShowDialog();
        }

        private void BtnAddStudents_Click(object sender, EventArgs e)
        {
            StudentFrm students = new StudentFrm();
            students.ClassName = SelectClassComboBox.Text;
            students.ClassId = (int)SelectClassComboBox.SelectedValue;
            students.ShowDialog();
        }

        private void BtnGetValues_Click(object sender, EventArgs e)
        {
            AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();
            DataTable dt = ada.GetDataBy((int)SelectClassComboBox.SelectedValue,
                                    SelectDateForClassDatePicker.Text);

            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = ada.GetDataBy((int)SelectClassComboBox.SelectedValue,
                                    SelectDateForClassDatePicker.Text);

                dataGridView1.DataSource = dt_new;
            }
            else
            {
                StudentsTBLTableAdapter students = new StudentsTBLTableAdapter();
                DataTable dt_Students = students.GetDataByClassId((int)SelectClassComboBox.SelectedValue);

                foreach (DataRow row in dt_Students.Rows)
                {
                    ada.InsertQuery((int)row[0], (int)SelectClassComboBox.SelectedValue, SelectDateForClassDatePicker.Text
                        , "", row[1].ToString(), SelectClassComboBox.SelectedValue.ToString());   
                }
                DataTable dt_new = ada.GetDataBy((int)SelectClassComboBox.SelectedValue,
                                    SelectDateForClassDatePicker.Text);

                dataGridView1.DataSource = dt_new;

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(),
                        (int)SelectClassComboBox.SelectedValue, Convert.ToDateTime(SelectDateForClassDatePicker.Text));    
                    }

                }
                DataTable dt_new = ada.GetDataBy((int)SelectClassComboBox.SelectedValue,
                                        SelectDateForClassDatePicker.Text);

                dataGridView1.DataSource = dt_new;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery("", row.Cells[0].Value.ToString(),
                    (int)SelectClassComboBox.SelectedValue, Convert.ToDateTime(SelectDateForClassDatePicker.Text));
                }

            }
            DataTable dt_new = ada.GetDataBy((int)SelectClassComboBox.SelectedValue,
                                    SelectDateForClassDatePicker.Text);

            dataGridView1.DataSource = dt_new;
        }

        private void BtnGetValuesInReportSection_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsTBLTableAdapter students = new StudentsTBLTableAdapter();
                DataTable dt_Students = students.GetDataByClassId((int)SelectClassComboBoxInReportSection.SelectedValue);

                AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();

                int presentStudent = 0;
                int absentStudent = 0;
                int lateStudent = 0;
                int execuseStudent = 0;
                foreach (DataRow row in dt_Students.Rows)
                {
                    //present count
                    presentStudent = (int)ada.GetDataByReport(SelectDateForClassDatePicker.Value.Month,
                        row[1].ToString(), "present").Rows[0][6];

                    

                    //absent count
                    absentStudent = (int)ada.GetDataByReport(SelectDateForClassDatePicker.Value.Month,
                    row[1].ToString(), "present").Rows[0][6];

                    //late count
                    lateStudent = (int)ada.GetDataByReport(SelectDateForClassDatePicker.Value.Month,
                    row[1].ToString(), "present").Rows[0][6];

                    //Execuse count
                    execuseStudent = (int)ada.GetDataByReport(SelectDateForClassDatePicker.Value.Month,
                    row[1].ToString(), "present").Rows[0][6];


                    ListViewItem listItem = new ListViewItem();

                    listItem.Text = row[1].ToString();
                    listItem.SubItems.Add(presentStudent.ToString());
                    listItem.SubItems.Add(absentStudent.ToString());
                    listItem.SubItems.Add(lateStudent.ToString());
                    listItem.SubItems.Add(execuseStudent.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }
    }
}
