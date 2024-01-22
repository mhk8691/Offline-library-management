using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offline_library
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
            Username.Text = "admin";
            password.Text = "admin";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (Username.Text == "admin" && password.Text == "admin")
            {
                Admin_panel admin_Panel = new Admin_panel();
                admin_Panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                password.Text = "";
            }
        }

        private void Admin_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "My First Application",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }
    }
}
