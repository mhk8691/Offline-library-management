using System;
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
    public partial class Condition_of_books : Form
    {
       

        public Condition_of_books()
        {
            InitializeComponent();
            Loanbooks();
        }
        string path = "";
        string filename = "Loan books.txt";
       
        string regx = @"[\r\n]+";
        string regx2 = @"\,";
        string[] Loanbooks3 = new string[2];
        

        public void Loanbooks()
        {
            listView1.Items.Clear();
            Regex re = new Regex(regx);
            path = Path.Combine(Application.StartupPath, filename);
            string Loanbooks = "";
            if (File.Exists(path))
            {
                 Loanbooks = File.ReadAllText(path);
            }
            string[] Loanbooks2 = re.Split(Loanbooks);

            Regex re2 = new Regex(regx2);
            foreach (string data in Loanbooks2)
            {
                Loanbooks3 = re2.Split(data);
                ListViewItem item = new ListViewItem(Loanbooks3);
                listView1.Items.Add(item);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                Loanbooks();
            }

            else if (tabControl.SelectedIndex == 1)
            {
                
            }
        }

        private void Condition_of_books_Load(object sender, EventArgs e)
        {


            


        }
    }
}
