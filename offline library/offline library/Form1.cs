using System.Runtime.InteropServices;
using System.Drawing;


namespace offline_library
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            Admin_login Admin_login = new Admin_login();
            Admin_login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(ProgressBar1.Value < 100)
            {
                ProgressBar1.Value++;
            }
            else
            {
                ProgressBar1.Location = new Point(2000, 3000);
                ProgressBar1.Visible = false;
                Login_btn.Visible = true;
                Admin_btn.Visible = true;

            }
        }
    }
}
