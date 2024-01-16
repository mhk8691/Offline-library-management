using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace offline_library
{
    public partial class edit_shelf : Form
    {
        public edit_shelf()
        {
            InitializeComponent();
        }


        private void edit_shelf_Shown(object sender, EventArgs e)
        {
            string filename = "edit_shelf.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);
            string[] user_data2 = re.Split(user_deta);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            string[] userdata3 = new string[2];
            foreach (string data in user_data2)
            {
                userdata3 = re2.Split(data);
            }
            name_shelf.Text = userdata3[0];
            order_shelf.Text = userdata3[1];
        }
        private void add_shelf_btn_Click(object sender, EventArgs e)
        {
            string filename2 = "shelf.txt";
            string path2 = Path.Combine(Application.StartupPath, filename2);
            string userslist = name_shelf.Text + "," + order_shelf.Text + Environment.NewLine;
            File.AppendAllText(path2, userslist);
            List_shelf list_Shelf = new List_shelf();

            list_Shelf.Show();
            this.Close();
        }

        private void edit_shelf_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
