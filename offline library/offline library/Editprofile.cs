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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace offline_library
{
    public partial class Editprofile : Form
    {

        public Editprofile()
        {
            InitializeComponent();


        }
        string image_edit = "";
        string id = "";
        string date = "";

        private void Editprofile_Shown(object sender, EventArgs e)
        {
            string filename2 = "edit profile.txt";
            string path2 = Path.Combine(Application.StartupPath, filename2);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path2);
            string[] user_data2 = re.Split(user_deta);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            List<string> userdata3 = new List<string>();
            foreach (string data in user_data2)
            {
                userdata3.AddRange(re2.Split(data));
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Editprofile_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
