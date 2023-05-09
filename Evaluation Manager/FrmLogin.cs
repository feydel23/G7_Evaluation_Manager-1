using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            if(username == "teacher" && password == "test")
            {
                this.Hide();
                FrmStudents frmStudents = new FrmStudents();
                frmStudents.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }
    }
}
