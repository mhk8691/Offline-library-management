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
    public partial class Reclaime : Form
    {
        public Reclaime()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        List<string> list2 = new List<string>();

        public void record()
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

                ListViewItem item = new ListViewItem(lending3);
                listView1.Items.Add(item);
                }
            }
        }

        public void reclaime()
        {
            string regx = @"[\r\n]+";
            Regex re = new Regex(regx);

            string filename = "lending.txt";
            string path = Path.Combine(Application.StartupPath, filename);

            string user_deta = File.ReadAllText(path);

            list.AddRange(re.Split(user_deta));

            ListViewItem selectindex = listView1.SelectedItems[0];
            int index = listView1.Items.IndexOf(selectindex);
            List<string> list2 = new List<string>();
            foreach(string data in list)
            {
                if(data != "")
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
            Reclaime_btn.Visible = false;
        }

        private void Reclaime_Shown(object sender, EventArgs e)
        {
            record();
        }

        private void Reclaime_btn_Click(object sender, EventArgs e)
        {
            reclaime();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reclaime_btn.Visible = true;
        }
    }
}
