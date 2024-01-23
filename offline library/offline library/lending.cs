using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class lending : Form
    {
        public lending()
        {
            InitializeComponent();
        }

        string textbox_user = "";
        string textbox_book = "";
        List<string> user_data2 = new List<string>();
        List<string> book_data2 = new List<string>();
        string fileName = "users list.txt";
        string fileName2 = "book list.txt";
        string path_lending = "";
        string filename_lending = "lending.txt";
        string NameBook = "";
        string CodeBook = "";
        string id = "";
        string author = "";
        string price = "";
        string publisher = "";
        string bookshelf = "";
        string createdat = "";
        string updatedat = "";
        string status = "";


        public string list(string filename)
        {
            string path = Path.Combine(Application.StartupPath, fileName);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = "";
            if (File.Exists(path))
            {
                user_deta = File.ReadAllText(path);
            }
            user_data2.AddRange(re.Split(user_deta));
            return filename;
        }

        public void search()
        {
            list(fileName);
            if (textbox_user.Length > 0)
            {
                string regx2 = @"\,";
                Regex re2 = new Regex(regx2);
                foreach (string item in user_data2)
                {
                    if(item != "")
                    {

                    string[] usersearch = re2.Split(item);
                    if (usersearch[0] == textbox_user)
                    {

                        username_lbl.Text = usersearch[0];
                        UserId_lbl.Text = usersearch[10];
                        

                    }
                        
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter something in the search box");
            }
        }

        public void list2()
        {
            string path = Path.Combine(Application.StartupPath, fileName2);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string book_data = "";
            if (File.Exists(path))
            {
                book_data = File.ReadAllText(path);
            }
            book_data2.AddRange(re.Split(book_data));

        }

        public void search_book()
        {
            
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            list2();
            if (textbox_book.Length > 0)
            {
                foreach (string item in book_data2)
                {
                    if(item != "")
                    {

                    string[] booksearch = re2.Split(item);
                    if (booksearch[0] == textbox_book)
                    {
                        listView1.Items.Clear();
                        NameBook = booksearch[0];
                        CodeBook = booksearch[1];
                        id = booksearch[2];
                        author = booksearch[3];
                        price = booksearch[4];
                        publisher = booksearch[5];
                        bookshelf = booksearch[6];
                        createdat = booksearch[7];
                        updatedat = booksearch[8];
                        status = booksearch[9];
                        ListViewItem items = new ListViewItem(booksearch);
                        listView1.Items.Add(items);
                        label3.Visible = true;
                        dateTimePicker1.Visible = true;
                        Record.Visible = true;
                    }
                        
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter something in the search box");
            }
        }


        private void search_user_TextChanged(object sender, EventArgs e)
        {
            textbox_user = search_user.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            search();
            label5.Visible = true;
            BookCode_search.Visible = true;
            pictureBox2.Visible = true;
        }

        private void BookCode_search_TextChanged(object sender, EventArgs e)
        {
            textbox_book = BookCode_search.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            search_book();

        }

        private void Record_Click(object sender, EventArgs e)
        {
            string regx = @"\s";
            Regex re = new Regex(regx);

            if (listView1.Items.Count > 0)
            {
                ListViewItem listViewItem = listView1.SelectedItems[0];
                int index = listView1.Items.IndexOf(listViewItem);
                List<string> list = new List<string>();
                foreach (ListViewItem.ListViewSubItem subItem in listView1.Items[index].SubItems)
                {
                    list.AddRange(subItem.Text.Split(regx));

                }
            string Loanbooks = "Loan books.txt";
            string path = Path.Combine(Application.StartupPath, Loanbooks);
            string currentDate = DateTime.Now.ToShortDateString();

            path_lending = Path.Combine(Application.StartupPath, filename_lending);
            string strings = username_lbl.Text + "," + UserId_lbl.Text + "," + NameBook + "," + CodeBook + "," + currentDate + "," + dateTimePicker1.Text + Environment.NewLine;

            File.AppendAllText(path_lending, strings);

            string Loanbooks_string = list[0] + "," + list[1] + "," + list[2] + "," + list[3] + "," + list[4] + "," + list[5] + "," + list[6] + "," + list[7] + "," + list[8] + "," + list[9] + Environment.NewLine;
            File.AppendAllText(path, Loanbooks_string);

            MessageBox.Show("It was successful!");
            this.Close();
            }
            else
            {
                MessageBox.Show("Please select");
            }


        }
    }
}
