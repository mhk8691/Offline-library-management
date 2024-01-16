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
using static offline_library.list_users;
using static System.Windows.Forms.DataFormats;

namespace offline_library
{
    public partial class edit_user : Form
    {


        public edit_user()
        {
            InitializeComponent();



        }
        string id = "";
        string date = "";
        string image_edit = "";


        private void edit_user_Shown(object sender, EventArgs e)
        {

            string filename = "edit.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);
            string[] user_data2 = re.Split(user_deta);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            string[] userdata3 = new string[13];
            foreach (string data in user_data2)
            {
                userdata3 = re2.Split(data);
            }
            Username.Text = userdata3[0];
            Password.Text = userdata3[1];
            Email.Text = userdata3[2];
            Fullname.Text = userdata3[3];
            Phone.Text = userdata3[4];
            Age.Text = userdata3[5];
            Gender.Text = userdata3[6];
            NationalId.Text = userdata3[7];
            City.Text = userdata3[8];
            Address.Text = userdata3[9];
            id = userdata3[10];
            date = userdata3[11];
            image_edit = userdata3[12];
            image.Image = Image.FromFile(image_edit);

        }


        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(open.FileName);
                image_edit = open.FileName;
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string filename = "users list.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string userslist = Username.Text + "," + Password.Text + "," + Email.Text + "," + Fullname.Text + "," + Phone.Text + "," + Age.Text + "," + Gender.Text + "," + NationalId.Text + "," + City.Text + "," + Address.Text + "," + id + "," + date + "," + image_edit + Environment.NewLine;
            File.AppendAllText(path, userslist);
            list_users list_Users = new list_users();
            list_Users.Show();
            this.Close();

        }

        private void edit_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
