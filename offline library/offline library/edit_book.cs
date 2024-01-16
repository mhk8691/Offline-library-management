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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace offline_library
{
    public partial class edit_book : Form
    {
        public edit_book()
        {
            InitializeComponent();
            string filename2 = "shelf.txt";
            string path_shelf = Path.Combine(Application.StartupPath, filename2);


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string shelf_list = File.ReadAllText(path_shelf);
            string[] shelf_list2 = re.Split(shelf_list);

            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            List<string> bookshelf = new List<string>();


            foreach (string data in shelf_list2)
            {

                string[] shelf_list3 = re2.Split(data);

                bookshelf.Add(shelf_list3[0]);

            }

            foreach (string data in bookshelf)
            {
                Bookshelf.Items.Add(data);
            }
        }
        string image_edit = "";
        string id = "";
        string status = "";

        private void edit_book_Shown(object sender, EventArgs e)
        {
            string filename = "edit_book.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);
            string[] user_data2 = re.Split(user_deta);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            string[] userdata3 = new string[11];
            foreach (string data in user_data2)
            {
                userdata3 = re2.Split(data);
            }
            Name_1.Text = userdata3[0];
            Code.Text = userdata3[1];
            id = userdata3[2];
            Author.Text = userdata3[3];
            Price.Text = userdata3[4];
            Publisher.Text = userdata3[5];
            Bookshelf.Text = userdata3[6];
            CreatedAt.Text = userdata3[7];
            UpdatedAt.Text = userdata3[8];
            label1.Visible = false;
            status = userdata3[9];
            image_edit = userdata3[10];
            image.Image = Image.FromFile(image_edit);
        }

        private void Add_book_btn_Click(object sender, EventArgs e)
        {
            string filename = "book list.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string Booklist = Name_1.Text + "," + Code.Text + "," + id + "," + Author.Text + "," + Price.Text + "," + Publisher.Text + "," + Bookshelf.Text + "," + CreatedAt.Text + "," + UpdatedAt.Text + "," + status + "," + image_edit + Environment.NewLine;

            File.AppendAllText(path, Booklist);
            List_book list_book = new List_book();
            list_book.Show();
            this.Close();
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

        private void edit_book_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // کاربر دکمه ضربدر را زده است
                e.Cancel = true; // لغو بستن فرم
                this.Hide(); // مخفی کردن فرم به جای بستن
            }
        }

        private void edit_book_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
