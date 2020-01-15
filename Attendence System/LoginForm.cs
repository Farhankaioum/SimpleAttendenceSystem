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
    public partial class LoginForm : Form
    {
        public bool LoginFlag { get; set; }
        public int UserId { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginFlag = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UserTableAdapter userAda = new DataSet1TableAdapters.UserTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(TxtUser.Text, TxtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                //valid login
                MessageBox.Show("Login Successfully!");
                UserId = int.Parse(dt.Rows[0]["UserId"].ToString());
                LoginFlag = true;
            }
            else
            {
                //not valid
                MessageBox.Show("Error Attemps!");
                LoginFlag = false;
            }
            Close();
        }
    }
}
