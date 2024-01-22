using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace offline_library
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        bool login = false;


        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            user user = new user();
            string fileName = "users list.txt";
            string path = Path.Combine(Application.StartupPath, fileName);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            string user_deta = "";
            if (File.Exists(path))
            {
                user_deta = File.ReadAllText(path);
            }
            string[] user_data2 = re.Split(user_deta);

            foreach (string data in user_data2)
            {
                string[] user_data3 = re2.Split(data);
                if(username.Text != "" && password.Text != "")
                {

                if (user_data3[0] == username.Text && user_data3[1] == password.Text)
                {
                    user.Show();
                    this.Hide();
                    login = true;
                    user.Instance.lbl.Text = username.Text;
                    user.Instance.lbl2.Text = password.Text;
                    return;
                }
                }
            }


            if (login == false)
            {
                MessageBox.Show("رمز عبور یا نام کاربری اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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
