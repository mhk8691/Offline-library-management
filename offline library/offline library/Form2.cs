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

namespace offline_library
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();

        }
        List<string> list = new List<string>();
        public void show()
        {
            string request_filename = "request.txt";
            string request_path = Path.Combine(Application.StartupPath, request_filename);
            string request_list = "";
            if (File.Exists(request_path))
            {
             request_list = File.ReadAllText(request_path);
            }
            string regx = @"[\r\n]+";
            string regx2 = @"\,";
            Regex re = new Regex(regx);
            Regex re2 = new Regex(regx2);
            string[] request_list2 = re.Split(request_list);

            foreach (string data in request_list2)
            {
                if(data != "")
                {
                    string[] request_list3 = re2.Split(data);
                    ListViewItem item = new ListViewItem(request_list3);
                    listView1.Items.Add(item);
                }
            }
        }
        public void delete()
        {


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);

            string fileName = "request.txt";
            string path = Path.Combine(Application.StartupPath, fileName);


          

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
            list2.RemoveAt(index);


            listView1.Items.Remove(selectindex);

            File.WriteAllText(path, "");
            foreach (string data in list2)
            {

                File.AppendAllText(path, data + Environment.NewLine);
            }
            Reject.Visible = false;
        }
        public void Accept_void()
        {
            string file_name = "lending.txt";
            string path = Path.Combine(Application.StartupPath, file_name);
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
                foreach (string data in list)
                {
                    File.AppendAllText(file_name, data + ",");
                }
                delete();
                File.AppendAllText(file_name, Environment.NewLine);
                MessageBox.Show("The book was made available to the user!");
            }
        }

        private void Request_Shown(object sender, EventArgs e)
        {
            show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Accept.Visible = true;
            Reject.Visible = true;


        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Accept_void();
            Reject.Visible=false;
            Accept.Visible = false;
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            delete();
            Accept.Visible = false;
            Reject.Visible=false;
        }
    }
}
