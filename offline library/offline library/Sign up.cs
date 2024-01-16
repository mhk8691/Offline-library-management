using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offline_library
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            //city
            string[] citystring = new string[15];
            citystring[0] = "Tehran";
            citystring[1] = "Mashhad";
            citystring[2] = "Isfahan";
            citystring[3] = "Tabriz";
            citystring[4] = "Shiraz";
            citystring[5] = "Ahvaz";
            citystring[6] = "Yazd";
            citystring[7] = "Kerman";
            citystring[8] = "Qom";
            citystring[9] = "Rasht";
            citystring[10] = "Hamedan";
            citystring[11] = "Zahedan";
            citystring[12] = "Kermanshah";
            citystring[13] = "Orumiyeh";
            citystring[14] = "Ardabil";

            foreach (string data in citystring)
            {
                city.Items.Add(data);
            }
        }


        string path = "";
        string gender = "";
        string ofd_image = "";
        

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (ofd_image != "" && username.Text != "" && password.Text != "" && email.Text != "" && fullname.Text != "" && phone.Text != "" && Age2.Text != "" && gender != "" && nationalid.Text != "" && city.Text != "" && address.Text != "" && checkBox1.Checked)
            {
                string currentDate = DateTime.Now.ToShortDateString();
                Random rnd = new Random();
                int random = rnd.Next(1000, 9999);
                string fileName = "users list.txt";
                path = Path.Combine(Application.StartupPath, fileName);
                string signup = username.Text + "," + password.Text + "," + email.Text + "," + fullname.Text + "," + phone.Text + "," + Age2.Text + "," + gender + "," + nationalid.Text + "," + city.Text + "," + address.Text + "," + random.ToString() + "," + currentDate + "," + ofd_image + Environment.NewLine;
                File.AppendAllText(path, signup);

                MessageBox.Show("Registration was successful!");
                list_users list_Users = new list_users();
                list_Users.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter your information");
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Age2.Text = Convert.ToString(age.Value);
        }



        private void gender_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = gender_male.Text;
        }

        private void gender_fmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = gender_fmale.Text;
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            city_lbl.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(ofd.FileName);
                ofd_image = ofd.FileName;
            }
        }

       
    }
}
