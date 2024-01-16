namespace offline_library
{
    partial class list_users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_users));
            label1 = new Label();
            delete = new Guna.UI2.WinForms.Guna2Button();
            Edit = new Guna.UI2.WinForms.Guna2Button();
            UserName = new ColumnHeader();
            Password = new ColumnHeader();
            Email = new ColumnHeader();
            FullName = new ColumnHeader();
            Phone = new ColumnHeader();
            Age = new ColumnHeader();
            Gender = new ColumnHeader();
            NationalId = new ColumnHeader();
            City = new ColumnHeader();
            Address = new ColumnHeader();
            Id = new ColumnHeader();
            Date = new ColumnHeader();
            listView1 = new ListView();
            View_btn = new Guna.UI2.WinForms.Guna2Button();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(438, 12);
            label1.Name = "label1";
            label1.Size = new Size(305, 43);
            label1.TabIndex = 0;
            label1.Text = "List of members";
            // 
            // delete
            // 
            delete.BackColor = Color.Transparent;
            delete.BorderColor = Color.FromArgb(39, 174, 96);
            delete.BorderRadius = 10;
            delete.BorderThickness = 3;
            delete.Cursor = Cursors.Hand;
            delete.CustomizableEdges = customizableEdges1;
            delete.DisabledState.BorderColor = Color.DarkGray;
            delete.DisabledState.CustomBorderColor = Color.DarkGray;
            delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delete.FillColor = Color.FromArgb(39, 174, 96);
            delete.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = Color.White;
            delete.HoverState.BorderColor = Color.FromArgb(39, 174, 96);
            delete.HoverState.FillColor = Color.White;
            delete.HoverState.ForeColor = Color.FromArgb(39, 174, 96);
            delete.Image = Properties.Resources.remove_user;
            delete.ImageAlign = HorizontalAlignment.Left;
            delete.ImageSize = new Size(30, 30);
            delete.Location = new Point(764, 485);
            delete.Name = "delete";
            delete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            delete.Size = new Size(300, 50);
            delete.TabIndex = 16;
            delete.Text = "Delete user";
            delete.UseTransparentBackground = true;
            delete.Visible = false;
            delete.Click += Delete_user;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Transparent;
            Edit.BorderColor = Color.FromArgb(39, 174, 96);
            Edit.BorderRadius = 10;
            Edit.BorderThickness = 3;
            Edit.Cursor = Cursors.Hand;
            Edit.CustomizableEdges = customizableEdges3;
            Edit.DisabledState.BorderColor = Color.DarkGray;
            Edit.DisabledState.CustomBorderColor = Color.DarkGray;
            Edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Edit.FillColor = Color.White;
            Edit.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = Color.FromArgb(39, 174, 96);
            Edit.HoverState.BorderColor = Color.FromArgb(39, 174, 96);
            Edit.HoverState.FillColor = Color.FromArgb(39, 174, 96);
            Edit.HoverState.ForeColor = Color.White;
            Edit.Image = Properties.Resources.edit;
            Edit.ImageAlign = HorizontalAlignment.Left;
            Edit.ImageSize = new Size(30, 30);
            Edit.Location = new Point(438, 485);
            Edit.Name = "Edit";
            Edit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Edit.Size = new Size(300, 50);
            Edit.TabIndex = 16;
            Edit.Text = "Edit Profile";
            Edit.UseTransparentBackground = true;
            Edit.Visible = false;
            Edit.Click += Edit_Click;
            // 
            // UserName
            // 
            UserName.Text = "UserName";
            UserName.Width = 81;
            // 
            // Password
            // 
            Password.Text = "Password";
            Password.TextAlign = HorizontalAlignment.Center;
            Password.Width = 80;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.TextAlign = HorizontalAlignment.Center;
            Email.Width = 100;
            // 
            // FullName
            // 
            FullName.Text = "FullName";
            FullName.TextAlign = HorizontalAlignment.Center;
            FullName.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "Phone";
            Phone.TextAlign = HorizontalAlignment.Center;
            Phone.Width = 110;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.TextAlign = HorizontalAlignment.Center;
            // 
            // Gender
            // 
            Gender.Text = "Gender";
            // 
            // NationalId
            // 
            NationalId.Text = "National Id";
            NationalId.TextAlign = HorizontalAlignment.Center;
            NationalId.Width = 110;
            // 
            // City
            // 
            City.Text = "City";
            City.TextAlign = HorizontalAlignment.Center;
            City.Width = 90;
            // 
            // Address
            // 
            Address.Text = "Address";
            Address.TextAlign = HorizontalAlignment.Center;
            Address.Width = 80;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.TextAlign = HorizontalAlignment.Center;
            // 
            // Date
            // 
            Date.Text = "Date";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UserName, Password, Email, FullName, Phone, Age, Gender, NationalId, City, Address, Id, Date });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.Green;
            listView1.Location = new Point(92, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(1014, 376);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // View_btn
            // 
            View_btn.BackColor = Color.Transparent;
            View_btn.BorderColor = Color.FromArgb(39, 174, 96);
            View_btn.BorderRadius = 10;
            View_btn.BorderThickness = 3;
            View_btn.Cursor = Cursors.Hand;
            View_btn.CustomizableEdges = customizableEdges5;
            View_btn.DisabledState.BorderColor = Color.DarkGray;
            View_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            View_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            View_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            View_btn.FillColor = Color.FromArgb(39, 174, 96);
            View_btn.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            View_btn.ForeColor = Color.White;
            View_btn.HoverState.BorderColor = Color.FromArgb(39, 174, 96);
            View_btn.HoverState.FillColor = Color.White;
            View_btn.HoverState.ForeColor = Color.FromArgb(39, 174, 96);
            View_btn.Image = Properties.Resources.view;
            View_btn.ImageAlign = HorizontalAlignment.Left;
            View_btn.ImageSize = new Size(30, 30);
            View_btn.Location = new Point(118, 485);
            View_btn.Name = "View_btn";
            View_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            View_btn.Size = new Size(300, 50);
            View_btn.TabIndex = 16;
            View_btn.Text = "View profile";
            View_btn.UseTransparentBackground = true;
            View_btn.Visible = false;
            View_btn.Click += View_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderColor = Color.FromArgb(128, 255, 255);
            textBoxSearch.BorderRadius = 7;
            textBoxSearch.BorderThickness = 2;
            textBoxSearch.CustomizableEdges = customizableEdges7;
            textBoxSearch.DefaultText = "";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(255, 128, 128);
            textBoxSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.IconRight = Properties.Resources.search4;
            textBoxSearch.Location = new Point(92, 26);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PasswordChar = '\0';
            textBoxSearch.PlaceholderText = "";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textBoxSearch.Size = new Size(200, 41);
            textBoxSearch.TabIndex = 17;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // list_users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(textBoxSearch);
            Controls.Add(Edit);
            Controls.Add(View_btn);
            Controls.Add(delete);
            Controls.Add(listView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "list_users";
            Text = " ";
            Shown += list_users_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
#pragma warning restore CS0169 // The field 'list_users.guna2Button1' is never used
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private ColumnHeader UserName;
        private ColumnHeader Password;
        private ColumnHeader Email;
        private ColumnHeader FullName;
        private ColumnHeader Phone;
        private ColumnHeader Age;
        private ColumnHeader Gender;
        private ColumnHeader NationalId;
        private ColumnHeader City;
        private ColumnHeader Address;
        private ColumnHeader Id;
        private ColumnHeader Date;
        private ListView listView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button View_btn;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
    }
}