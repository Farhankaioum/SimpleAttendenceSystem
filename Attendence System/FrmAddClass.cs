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
    public partial class FrmAddClass : Form
    {
        public int UserId { get; set; }

        public FrmAddClass()
        {
            InitializeComponent();
        }

        private void FrmAddClass_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassTBLTableAdapter ada = new DataSet1TableAdapters.ClassTBLTableAdapter();
            ada.AddClass(BtnClassName.Text, UserId);
            Close();
        }
    }
}
