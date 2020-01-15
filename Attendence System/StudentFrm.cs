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
    public partial class StudentFrm : Form
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }


        public StudentFrm()
        {
            InitializeComponent();
        }

        private void StudentFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);

            LabelClassName.Text = ClassName;
            LabelClassId.Text = ClassId.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
        }
    }
}
