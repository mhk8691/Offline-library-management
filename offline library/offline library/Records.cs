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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

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
                string[] lending3 = re2.Split(data);
                ListViewItem item = new ListViewItem(lending3);
                listView1.Items.Add(item);
            }
        }
        private void Records_Shown(object sender, EventArgs e)
        {
            record();
        }
    }
}
