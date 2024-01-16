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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace offline_library
{

    public partial class profile : Form
    {
        public static profile Instance;
        public Label lbl;
        public Label lbl2;
        public Label lbl3;
        public Label lbl4;
        public Label lbl5;
        public Label lbl6;
        public Label lbl7;
        public Label lbl8;
        public Label lbl9;
        public Label lbl10;
        public Label lbl11;
        public Label lbl12;
        public string imagepath;

        public profile()
        {
            InitializeComponent();
            Instance = this;
            lbl = username_lbl;
            lbl2 = password_lbl;
            lbl3 = email_lbl;
            lbl4 = fullname_lbl;
            lbl5 = phone_lbl;
            lbl6 = age_lbl;
            lbl7 = gender_lbl;
            lbl8 = nationalid_lbl;
            lbl9 = city_lbl;
            lbl10 = address_lbl;
            lbl11 = id_lb;
            lbl12 = date_lbl;

        }




        private void profile_Shown(object sender, EventArgs e)
        {
            image.Image = Image.FromFile(imagepath);

        }

        private void profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // کاربر دکمه ضربدر را زده است
                e.Cancel = true; // لغو بستن فرم
                this.Hide(); // مخفی کردن فرم به جای بستن
            }
        }
    }
}
