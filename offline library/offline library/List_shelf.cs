using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offline_library
{
    public partial class List_shelf : Form
    {
        public List_shelf()
        {
            InitializeComponent();
        }
        string path = "";
        string fileName = "shelf.txt";


        private void List_shelf_Shown(object sender, EventArgs e)
        {
            
                
            

            path = Path.Combine(Application.StartupPath, fileName);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = "";
            if (File.Exists(path))
            {
                 user_deta = File.ReadAllText(path);
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
        }

        private void delete_Click(object sender, EventArgs e)
        {
            path = Path.Combine(Application.StartupPath, fileName);


            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);
            List<string> list = new List<string>();
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



        private void Edit_Click(object sender, EventArgs e)
        {
            string filename2 = "edit_shelf.txt";
            string path2 = Path.Combine(Application.StartupPath, filename2);
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);
            string user_deta = File.ReadAllText(path);
            List<string> list = new List<string>();
            list.AddRange(re.Split(user_deta));

            ListViewItem selectindex = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selectindex);
            if (index >= 0 && index < list.Count)
            {
                File.WriteAllText(path2, list[index]);
                list.RemoveAt(index);

            }
            File.WriteAllText(path, "");
            foreach (string item in list)
            {
                File.AppendAllText(path, item + Environment.NewLine);
            }
            edit_shelf edit_Shelf = new edit_shelf();
            edit_Shelf.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Visible = true;
            Edit.Visible = true;
        }
    }
}
