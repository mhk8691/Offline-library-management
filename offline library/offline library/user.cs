using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace offline_library
{
    public partial class user : Form
    {
        public static user Instance;
        public Label lbl;
        public Label lbl2;
        public user()
        {
            InitializeComponent();
            Instance = this;
            lbl = username_lbl;
            lbl2 = password_lbl;
        }
        string image_path = "";
        string date = "";
        string id = "";
        //searchbook
        List<string> book_data2 = new List<string>();
        string NameBook = "";
        string CodeBook = "";
        string idbook = "";
        string author = "";
        string price = "";
        string publisher = "";
        string bookshelf = "";
        string createdat = "";
        string updatedat = "";
        string status = "";
        string path_lending = "";
        string filename_lending = "lending.txt";
        static string RemoveLastCharacter(string input)
        {
            // اطمینان حاصل کنید که رشته حداقل یک حرف دارد
            if (!string.IsNullOrEmpty(input) && input.Length > 1)
            {
                // استخراج همه‌ی حروف به جز حرف آخر و بازگرداندن رشته نهایی
                return input.Substring(0, input.Length - 1);
            }
            else
            {
                // اگر رشته خالی یا null باشد یا فقط یک حرف داشته باشد، می‌توانید خروجی مورد نظر را تعیین کنید.
                return "رشته ورودی نامعتبر است.";
            }
        }

        static void RemoveStringFromList(string targetString, List<string> stringList)
        {
            // استفاده از متد RemoveAll برای حذف همه‌ی عناصر مطابق با رشته
            stringList.RemoveAll(str => str == targetString);
        }
        public void my_book()
        {

            string filename = "lending.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string lending = "";
            if (File.Exists(path))
            {
                lending = File.ReadAllText(path);
            }
            string[] lending2 = re.Split(lending);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            foreach (string data in lending2)
            {
                if(data != "")
                {
                    string[] lending3 = re2.Split(data);
                    if (lending3[0] == username_lbl.Text && lending3[1] == id)
                    {
                        ListViewItem item = new ListViewItem(lending3);
                        listView2.Items.Add(item);
                    }
                }
            }


        }

        public void delete()
        {
            List<string> list = new List<string>();

            string fileName = "lending.txt";
            string path = Path.Combine(Application.StartupPath, fileName);


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);

            list.AddRange(re.Split(user_deta));

            ListViewItem selectindex = listView2.SelectedItems[0];
            int index = listView2.Items.IndexOf(selectindex);
            string rowString = "";
            foreach (ListViewItem.ListViewSubItem subItem in listView2.Items[index].SubItems)
            {
                rowString += subItem.Text + ",";
            }
            string resultString = RemoveLastCharacter(rowString);
            RemoveStringFromList(resultString, list);

            listView2.Items.Remove(selectindex);

            File.WriteAllText(path, "");
            foreach (string data in list)
            {

                File.AppendAllText(path, data + Environment.NewLine);
            }
        }


        public void list2()
        {
            string fileName2 = "book list.txt";
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

        public void request()

        {
            string NameBook2 = "";
            string CodeBook2 = "";
            string fileName = "book list.txt";
            string book_path = Path.Combine(Application.StartupPath, fileName);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(book_path);
            List<string> list = new List<string>();
            list.AddRange(re.Split(user_deta));
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            ListViewItem selectindex = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selectindex);
                List<string> list_book = new List<string>();
                List<string> list2 = new List<string>();
            if (index >= 0 && index < list.Count)
            {
                list_book.Add(list[index]);
                list2.Add(list[index]);
            }
            foreach (string item in list2)
            {
                string[] book_data = re2.Split(item);
                NameBook2 = book_data[0];   
                CodeBook2 = book_data[1];
            }

            string request_filename = "request.txt";
            string request_path = Path.Combine(Application.StartupPath, request_filename);

            string currentDate = DateTime.Now.ToShortDateString();
            string strings = username_lbl.Text + "," + id + "," + NameBook2 + "," + CodeBook2 + "," + currentDate + "," + dateTimePicker1.Text + Environment.NewLine;

            File.AppendAllText(request_path, strings);
            MessageBox.Show("Your request has been registered");
        }

        public void search_book()
        {

            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            list2();
            if (textBoxSearch.Text.Length > 0)
            {
                foreach (string item in book_data2)
                {
                    string[] booksearch = re2.Split(item);
                    if (booksearch[0] == textBoxSearch.Text)
                    {

                        listView1.Items.Clear();
                        NameBook = booksearch[0];
                        CodeBook = booksearch[1];

                        ListViewItem items = new ListViewItem(booksearch);
                        listView1.Items.Add(items);
                        label3.Visible = true;

                    }

                }
            }

        }

        public void profile()
        {
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            //Show information
            string fileName = "users list.txt";
            string path2 = Path.Combine(Application.StartupPath, fileName);
            string user_deta = File.ReadAllText(path2);
            string[] user_data2 = re.Split(user_deta);

            foreach (string data in user_data2)
            {
                string[] userdata3 = re2.Split(data);
                if (userdata3[0] == username_lbl.Text && userdata3[1] == password_lbl.Text)
                {
                    email_lbl.Text = userdata3[2];
                    fullname_lbl.Text = userdata3[3];
                    phone_lbl.Text = userdata3[4];
                    age_lbl.Text = userdata3[5];
                    gender_lbl.Text = userdata3[6];
                    nationalid_lbl.Text = userdata3[7];
                    city_lbl.Text = userdata3[8];
                    address_lbl.Text = userdata3[9];
                    id = userdata3[10];
                    date = userdata3[11];
                    image_path = userdata3[12];
                    image.Image = Image.FromFile(image_path);
                }
            }
        }

        public void enteghad()
        {
            string filename = "critics and suggestions.txt";
            string path = Path.Combine(Application.StartupPath, filename);
            string text = richTextBox1.Text;
            File.AppendAllText(path, text + Environment.NewLine);
            MessageBox.Show("thank you!");
            richTextBox1.Text = "";
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                profile();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                string pathbook = "";
                string fileName = "book list.txt";
                pathbook = Path.Combine(Application.StartupPath, fileName);
                string regx = @"[\r\n]+";
                Regex re = new Regex(regx);
                string user_deta = "";
                if (File.Exists(pathbook))
                {
                    user_deta = File.ReadAllText(pathbook);
                }
                string[] user_data2 = re.Split(user_deta);
                string regx2 = @"\,";
                Regex re2 = new Regex(regx2);
                foreach (string data in user_data2)
                {
                    if(data != "")
                    {
                        string[] user_data3 = re2.Split(data);
                        ListViewItem item = new ListViewItem(user_data3);
                        listView1.Items.Add(item);
                    }
                }

                search_book();

            }
            else if (tabControl.SelectedIndex == 4)
            {

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (tabControl.SelectedIndex == 3)
            {

            }
        }

        private void user_Shown(object sender, EventArgs e)
        {
            profile();
            my_book();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            //Show information
            string fileName = "users list.txt";
            string path2 = Path.Combine(Application.StartupPath, fileName);
            string user_deta = File.ReadAllText(path2);
            string[] user_data2 = re.Split(user_deta);
            int count = 0;

            foreach (string data2 in user_data2)
            {
                string[] userdata3 = re2.Split(data2);


                if (userdata3[0] == username_lbl.Text && userdata3[1] == password_lbl.Text)
                {


                    user_data2[count] = "";

                }
                else
                {
                    count++;

                }

            }

            File.WriteAllText(path2, "");
            foreach (string data3 in user_data2)
            {
                File.AppendAllText(path2, data3 + Environment.NewLine);
            }

            string edit = username_lbl.Text + "," + password_lbl.Text + "," + email_lbl.Text + "," + fullname_lbl.Text + "," + phone_lbl.Text + "," + age_lbl.Text + "," + gender_lbl.Text + "," + nationalid_lbl.Text + "," + city_lbl.Text + "," + address_lbl.Text + "," + id + "," + date + "," + image_path + Environment.NewLine;
            string edit_name = "edit profile.txt";
            string path = Path.Combine(Application.StartupPath, edit_name);
            File.WriteAllText(path, edit);
            Editprofile editprofile = new Editprofile();
            editprofile.Show();
            this.Close();





        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_book();
            request_btn.Visible = true;
            dateTimePicker1.Visible = true;
            ReturnDate.Visible = true;
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            request();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            enteghad();
        }

        private void Give_back_Click(object sender, EventArgs e)
        {
            delete();
            Give_back.Visible = false;

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Give_back.Visible = true;
        }

        private void user_FormClosing(object sender, FormClosingEventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            request_btn.Visible=true;
        }
    }
}

