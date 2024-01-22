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
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        list_users list_Users = new list_users();

        List_book list_Book = new List_book();
        List_shelf list_Shelf = new List_shelf();

        private void OpenForm()
        {
            // اگر نمونه از فرم وجود نداشته باشد یا dispose شده باشد
            if (list_Book == null || list_Book.IsDisposed)
            {
                list_Book = new List_book();
                // در اینجا می‌توانید تنظیمات اولیه یا داده‌های مورد نیاز دیگر را انجام دهید
            }

            // نمایش فرم
            list_Book.Show();
        }
        private void OpenForm3()
        {
            // اگر نمونه از فرم وجود نداشته باشد یا dispose شده باشد
            if (list_Shelf == null || list_Shelf.IsDisposed)
            {
                list_Shelf = new List_shelf();
                // در اینجا می‌توانید تنظیمات اولیه یا داده‌های مورد نیاز دیگر را انجام دهید
            }

            // نمایش فرم
            list_Shelf.Show();
        }
        private void OpenForm2()
        {
            // اگر نمونه از فرم وجود نداشته باشد یا dispose شده باشد
            if (list_Users == null || list_Users.IsDisposed)
            {
                list_Users = new list_users();
                // در اینجا می‌توانید تنظیمات اولیه یا داده‌های مورد نیاز دیگر را انجام دهید
            }

            // نمایش فرم
            list_Users.Show();
        }




        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void addUsersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sign_up sign_up = new Sign_up();
            if (sign_up == null || sign_up.IsDisposed)
            {
                sign_up = new Sign_up();

            }


            sign_up.Show();


        }


        private void list_user_Click(object sender, EventArgs e)
        {
            OpenForm2();

        }

        private void listOfUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm2();


        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_book add_Book = new add_book();
            if (add_Book == null || add_Book.IsDisposed)
            {
                add_Book = new add_book();

            }


            add_Book.Show();


        }

        private void list_book_Click(object sender, EventArgs e)
        {
            OpenForm();

        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm2();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm();

        }

        private void listOfShelvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm3();

        }

        private void addShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_shelf add_Shelf = new Add_shelf();
            if (add_Shelf == null || add_Shelf.IsDisposed)
            {
                add_Shelf = new Add_shelf();

            }



            add_Shelf.Show();

        }

        private void deleteShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm3();


        }

        private void list_shelf_Click(object sender, EventArgs e)
        {
            OpenForm3();


        }

        private void editShelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm3();


        }

        private void editeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm2();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm();
        }



        private void Reclaim_Click(object sender, EventArgs e)
        {
            Reclaime reclaime = new Reclaime();


            if (reclaime == null || reclaime.IsDisposed)
            {
                reclaime = new Reclaime();

            }



            reclaime.Show();
        }

        private void condition_Click(object sender, EventArgs e)
        {
            Condition_of_books cob = new Condition_of_books();


            if (cob == null || cob.IsDisposed)
            {
                cob = new Condition_of_books();

            }



            cob.Show();
        }

        private void Records_Click(object sender, EventArgs e)
        {
            Records records = new Records();


            if (records == null || records.IsDisposed)
            {
                records = new Records();

            }



            records.Show();
        }

        private void Lending_book_Click(object sender, EventArgs e)
        {
            lending lending = new lending();


            if (lending == null || lending.IsDisposed)
            {
                lending = new lending();

            }



            lending.Show();
        }

        private void Admin_information_Click(object sender, EventArgs e)
        {
            admin_image.Visible = true;
            username_pic.Visible = true;
            password_pic.Visible = true;
            Username.Visible = true;
            Password.Visible = true;
            Username_lbl.Visible = true;
            Password_lbl.Visible = true;
            fullname_pic.Visible = true;
            Fullname.Visible = true;
            Fullname_lbl.Visible = true;
            phone_pic.Visible = true;
            Phone_lbl.Visible = true;
            phone.Visible = true;
        }





        private void Request_btn_Click(object sender, EventArgs e)
        {
            Request form2 = new Request();
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Request();
            }
            form2.ShowDialog();
        }

        private void Admin_panel_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
