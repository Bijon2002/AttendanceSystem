using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem.project.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
			string user = txtUsername.Text;
			string pass = txtPassword.Text;

			if (user == "admin" && pass == "admin123")
			{
				MessageBox.Show("Welcome Admin!");
				AdminForm admin = new AdminForm();
				admin.Show();
				this.Hide();
			}
			else if (user == "user" && pass == "user123")
			{
				MessageBox.Show("Welcome User!");
				UserForm userForm = new UserForm();
				userForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid login!");
			}
		}
    }
}
