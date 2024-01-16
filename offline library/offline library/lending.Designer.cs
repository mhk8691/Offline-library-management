namespace offline_library
{
    partial class lending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lending));
            search_user = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label22 = new Label();
            username_lbl = new Label();
            label2 = new Label();
            UserId_lbl = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            BookCode_search = new Guna.UI2.WinForms.Guna2TextBox();
            Record = new Guna.UI2.WinForms.Guna2Button();
            dateTimePicker1 = new DateTimePicker();
            listView1 = new ListView();
            Name1 = new ColumnHeader();
            Code = new ColumnHeader();
            Id = new ColumnHeader();
            Author = new ColumnHeader();
            Price = new ColumnHeader();
            Publisher = new ColumnHeader();
            Bookshelf = new ColumnHeader();
            CreatedAt = new ColumnHeader();
            UpdatedAt = new ColumnHeader();
            Status = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // search_user
            // 
            search_user.BorderColor = Color.FromArgb(204, 172, 0);
            search_user.BorderRadius = 7;
            search_user.BorderThickness = 2;
            search_user.CustomizableEdges = customizableEdges1;
            search_user.DefaultText = "";
            search_user.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_user.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_user.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_user.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_user.FocusedState.BorderColor = Color.FromArgb(204, 172, 0);
            search_user.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            search_user.Location = new Point(112, 12);
            search_user.Name = "search_user";
            search_user.PasswordChar = '\0';
            search_user.PlaceholderText = "";
            search_user.SelectedText = "";
            search_user.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_user.Size = new Size(258, 38);
            search_user.TabIndex = 0;
            search_user.TextChanged += search_user_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 172, 0);
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_search__1_;
            pictureBox1.Location = new Point(376, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(204, 172, 0);
            label22.Location = new Point(941, 81);
            label22.Name = "label22";
            label22.Size = new Size(136, 25);
            label22.TabIndex = 3;
            label22.Text = "User name:";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(1083, 81);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(21, 25);
            username_lbl.TabIndex = 4;
            username_lbl.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 172, 0);
            label2.Location = new Point(941, 128);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "User Id:";
            // 
            // UserId_lbl
            // 
            UserId_lbl.AutoSize = true;
            UserId_lbl.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserId_lbl.Location = new Point(1047, 128);
            UserId_lbl.Name = "UserId_lbl";
            UserId_lbl.Size = new Size(21, 25);
            UserId_lbl.TabIndex = 4;
            UserId_lbl.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(204, 172, 0);
            label3.Location = new Point(941, 174);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 6;
            label3.Text = "Return Date:";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_search__1_;
            pictureBox2.Location = new Point(881, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(204, 172, 0);
            label5.Location = new Point(521, 22);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "BookName:";
            label5.Visible = false;
            // 
            // BookCode_search
            // 
            BookCode_search.BorderColor = Color.FromArgb(204, 172, 0);
            BookCode_search.BorderRadius = 7;
            BookCode_search.BorderThickness = 2;
            BookCode_search.CustomizableEdges = customizableEdges3;
            BookCode_search.DefaultText = "";
            BookCode_search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            BookCode_search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            BookCode_search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            BookCode_search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            BookCode_search.FocusedState.BorderColor = Color.FromArgb(204, 172, 0);
            BookCode_search.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BookCode_search.Location = new Point(617, 12);
            BookCode_search.Name = "BookCode_search";
            BookCode_search.PasswordChar = '\0';
            BookCode_search.PlaceholderText = "";
            BookCode_search.SelectedText = "";
            BookCode_search.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BookCode_search.Size = new Size(258, 38);
            BookCode_search.TabIndex = 8;
            BookCode_search.Visible = false;
            BookCode_search.TextChanged += BookCode_search_TextChanged;
            // 
            // Record
            // 
            Record.BorderColor = Color.FromArgb(204, 172, 0);
            Record.BorderRadius = 15;
            Record.BorderThickness = 3;
            Record.Cursor = Cursors.Hand;
            Record.CustomizableEdges = customizableEdges5;
            Record.DisabledState.BorderColor = Color.DarkGray;
            Record.DisabledState.CustomBorderColor = Color.DarkGray;
            Record.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Record.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Record.FillColor = Color.FromArgb(204, 172, 0);
            Record.Font = new Font("Century", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Record.ForeColor = Color.White;
            Record.HoverState.BorderColor = Color.FromArgb(204, 172, 0);
            Record.HoverState.FillColor = Color.White;
            Record.HoverState.ForeColor = Color.FromArgb(204, 172, 0);
            Record.Location = new Point(357, 480);
            Record.Name = "Record";
            Record.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Record.Size = new Size(346, 59);
            Record.TabIndex = 11;
            Record.Text = "Record";
            Record.Visible = false;
            Record.Click += Record_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(941, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name1, Code, Id, Author, Price, Publisher, Bookshelf, CreatedAt, UpdatedAt, Status });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.Green;
            listView1.Location = new Point(90, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(830, 376);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Name1
            // 
            Name1.Text = "Name";
            Name1.Width = 81;
            // 
            // Code
            // 
            Code.Text = "Code";
            Code.TextAlign = HorizontalAlignment.Center;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.TextAlign = HorizontalAlignment.Center;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.TextAlign = HorizontalAlignment.Center;
            Author.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            Price.Width = 70;
            // 
            // Publisher
            // 
            Publisher.Text = "Publisher";
            Publisher.TextAlign = HorizontalAlignment.Center;
            Publisher.Width = 100;
            // 
            // Bookshelf
            // 
            Bookshelf.Text = "Bookshelf";
            Bookshelf.TextAlign = HorizontalAlignment.Center;
            Bookshelf.Width = 80;
            // 
            // CreatedAt
            // 
            CreatedAt.Text = "CreatedAt";
            CreatedAt.Width = 80;
            // 
            // UpdatedAt
            // 
            UpdatedAt.Text = "UpdatedAt";
            UpdatedAt.TextAlign = HorizontalAlignment.Center;
            UpdatedAt.Width = 110;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 80;
            // 
            // lending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1184, 561);
            Controls.Add(listView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Record);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(BookCode_search);
            Controls.Add(label3);
            Controls.Add(UserId_lbl);
            Controls.Add(username_lbl);
            Controls.Add(label2);
            Controls.Add(label22);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(search_user);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "lending";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox search_user;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label22;
        private Label username_lbl;
        private Label label2;
        private Label UserId_lbl;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox BookCode_search;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Record;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private ListView listView1;
        private ColumnHeader Name1;
        private ColumnHeader Code;
        private ColumnHeader Id;
        private ColumnHeader Author;
        private ColumnHeader Price;
        private ColumnHeader Publisher;
        private ColumnHeader Bookshelf;
        private ColumnHeader CreatedAt;
        private ColumnHeader UpdatedAt;
        private ColumnHeader Status;
    }
}