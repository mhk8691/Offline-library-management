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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace offline_library
{
    public partial class add_book : Form
    {
        public add_book()
        {
            InitializeComponent();




        }
        string ofd_image = "";
        string fileName = "";
        string path = "";

        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(ofd.FileName);
                ofd_image = ofd.FileName;
            }
        }

        private void Add_book_btn_Click(object sender, EventArgs e)
        {
            string Status = "true";
            Random rnd = new Random();
            int random = rnd.Next(1000, 9999);
            if (Name_1.Text != "" && Code.Text != "" && Author.Text != "" && Price.Text != "" && Publisher.Text != "" && Bookshelf.Text != "" && CreatedAt.Text != "" && UpdatedAt.Text != "" && ofd_image != "")
            {

                fileName = "book list.txt";
                path = Path.Combine(Application.StartupPath, fileName);
                string Book = Name_1.Text + "," + Code.Text + "," + random + "," + Author.Text + "," + Price.Text + "," + Publisher.Text + "," + Bookshelf.Text + "," + CreatedAt.Text + "," + UpdatedAt.Text + "," + Status + "," + ofd_image + Environment.NewLine;
                File.AppendAllText(path, Book);
                MessageBox.Show("The book has been successfully added");
                List_book list_Book = new List_book();

                list_Book.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please enter your information");
            }
        }

        private void Bookshelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void add_book_Load(object sender, EventArgs e)
        {
            string filename2 = "shelf.txt";
            string path_shelf = Path.Combine(Application.StartupPath, filename2);


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string shelf_list = "";
            
                 shelf_list = File.ReadAllText(path_shelf);
            
            
            string[] shelf_list2 = re.Split(shelf_list);

            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            List<string> bookshelf = new List<string>();

            
            foreach (string data in shelf_list2)
            {

              string[]  shelf_list3 = re2.Split(data);
                bookshelf.Add(shelf_list3[0]);


            }
            foreach (string data in bookshelf)
            {
                Bookshelf.Items.Add(data);

            }

        }
    }
}
