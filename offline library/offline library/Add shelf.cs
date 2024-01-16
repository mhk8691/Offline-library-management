using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offline_library
{
    public partial class Add_shelf : Form
    {
        public Add_shelf()
        {
            InitializeComponent();
        }
       



        private void add_shelf_btn_Click(object sender, EventArgs e)
        {
            if (name_shelf.Text != "" && order_shelf.Text != "")
            {

                Random random = new Random();
                int rnd = random.Next(1000, 9999);
                string fileName = "shelf.txt";
                string path = Path.Combine(Application.StartupPath, fileName);
                string add_shelf = name_shelf.Text + "," + order_shelf.Text + "," + rnd + Environment.NewLine;
                File.AppendAllText(path, add_shelf);
                MessageBox.Show("It was successful");
                List_shelf list_Shelf = new List_shelf();
                list_Shelf.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter your information");

            }
        }

        
    }
}
