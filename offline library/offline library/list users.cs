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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.DataFormats;
using System.Reflection;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Policy;

namespace offline_library
{
    public partial class list_users : Form
    {
        public static list_users Instance;



        public list_users()
        {
            InitializeComponent();
            Instance = this;


            path = Path.Combine(Application.StartupPath, fileName);
            if (File.Exists(path))
            {
                string regx = @"[\r\n]+";
                Regex re = new Regex(regx);
                string user_search = File.ReadAllText(path);
                string[] user_search2 = re.Split(user_search);


                foreach (string data in user_search2)
                {

                    users2.Add(data);
                }
            }
        }
        

        string path = "";
        string fileName = "users list.txt";
        private List<string> users2 = new List<string>();
        List<string> list = new List<string>();
        List<string> book_data2 = new List<string>();

        string textbox_search = "";

        int index_edit;

        public void edit_click()
        {
            string filename2 = "edit.txt";
            string path2 = Path.Combine(Application.StartupPath, filename2);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string regx2 = @"\,";
            Regex re2 = new Regex(regx2);
            string user_deta = File.ReadAllText(path);
            List<string> list = new List<string>();
            list.AddRange(re.Split(user_deta));

            if (listView1.Items.Count > 0)
            {
                ListViewItem selectindex = listView1.SelectedItems[0];
                index_edit = listView1.Items.IndexOf(selectindex);

            }

            foreach (string data2 in list)
            {
                if(data2 != "")
                {
                    string[] userdata3 = re2.Split(data2);
                }


               

            }

            if (index_edit >= 0 && index_edit < list.Count)
            {
                File.WriteAllText(path2, list[index_edit]);
                list.RemoveAt(index_edit);

            }
            File.WriteAllText(path, "");
            foreach (string item in list)
            {
                File.AppendAllText(path, item + Environment.NewLine);
            }
            edit_user edit_User = new edit_user();
            edit_User.Show();
            this.Close();
        }
        
        public void search()
        {
            if (textbox_search.Length > 0)
            {
                string regx2 = @"\,";
                Regex re2 = new Regex(regx2);
                foreach (string item in users2)
                {
                    string[] test = re2.Split(item);




                    if (test[0] == textbox_search)
                    {
                        foreach (string item2 in users2)
                        {
                            string[] list222 = re2.Split(item2);

                            if (list222[0] == textbox_search)
                            {


                                listView1.Items.Clear();


                                ListViewItem itemss = new ListViewItem(list222);

                                listView1.Items.Add(itemss);

                            }


                        }
                    }

                }
            }
            else
            {
                listView1.Items.Clear ();
                list_show();
            }
        }

        public void list_show()
        {

            path = Path.Combine(Application.StartupPath, fileName);
            if (File.Exists(path))
            {
                Console.WriteLine("فایل وجود دارد.");
                string regx = @"[\r\n]+";
                Regex re = new Regex(regx);
                string user_deta = File.ReadAllText(path);
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
            }
        }


        private void list_users_Shown(object sender, EventArgs e)
        {


            list_show();

        }

        private void Delete_user(object sender, EventArgs e)
        {


            path = Path.Combine(Application.StartupPath, fileName);


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);

            list.AddRange(re.Split(user_deta));

            ListViewItem selectindex = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selectindex);
            List<string> list2 = new List<string>();
            foreach (string data in list)
            {
                if (data != "")
                {
                    list2.Add(data);
                }
            }
            if (index >= 0 && index < list2.Count)
            {
                list2.RemoveAt(index);
                
            }
            listView1.Items.Remove(selectindex);

            File.WriteAllText(path, "");
            foreach (string data in list2)
            {

                File.AppendAllText(path, data + Environment.NewLine);
            }


        }

        private void View_Click(object sender, EventArgs e)
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

                profile profile = new profile();

                profile.Instance.lbl.Text = list[0];
                profile.Instance.lbl2.Text = list[1];
                profile.Instance.lbl3.Text = list[2];
                profile.Instance.lbl4.Text = list[3];
                profile.Instance.lbl5.Text = list[4];
                profile.Instance.lbl6.Text = list[5];
                profile.Instance.lbl7.Text = list[6];
                profile.Instance.lbl8.Text = list[7];
                profile.Instance.lbl9.Text = list[8];
                profile.Instance.lbl10.Text = list[9];
                profile.Instance.lbl11.Text = list[10];
                profile.Instance.lbl12.Text = list[11];
                profile.Instance.imagepath = list[12];
                profile.Show();
                this.Close();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            edit_click();
            search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            textbox_search = textBoxSearch.Text;
            search();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Visible = true;
            Edit.Visible = true;
            View_btn.Visible = true;

        }

        

       

       
    }
}
