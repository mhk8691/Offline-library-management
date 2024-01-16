namespace offline_library
{
    partial class edit_book
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_book));
            image = new PictureBox();
            label1 = new Label();
            Bookshelf = new Guna.UI2.WinForms.Guna2ComboBox();
            UpdatedAt = new Guna.UI2.WinForms.Guna2TextBox();
            CreatedAt = new Guna.UI2.WinForms.Guna2TextBox();
            Publisher = new Guna.UI2.WinForms.Guna2TextBox();
            Price = new Guna.UI2.WinForms.Guna2TextBox();
            Author = new Guna.UI2.WinForms.Guna2TextBox();
            Code = new Guna.UI2.WinForms.Guna2TextBox();
            Name_1 = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Add_book_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.Cursor = Cursors.Hand;
            image.Image = Properties.Resources.picture1;
            image.Location = new Point(155, 24);
            image.Name = "image";
            image.Size = new Size(100, 100);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 0;
            image.TabStop = false;
            image.Click += image_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(125, 137, 149);
            label1.Location = new Point(111, 483);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 12;
            label1.Text = "Bookshelf";
            // 
            // Bookshelf
            // 
            Bookshelf.BackColor = Color.Transparent;
            Bookshelf.BorderRadius = 7;
            Bookshelf.BorderThickness = 0;
            Bookshelf.CustomizableEdges = customizableEdges1;
            Bookshelf.DrawMode = DrawMode.OwnerDrawFixed;
            Bookshelf.DropDownStyle = ComboBoxStyle.DropDownList;
            Bookshelf.FocusedColor = Color.FromArgb(94, 148, 255);
            Bookshelf.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Bookshelf.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Bookshelf.ForeColor = Color.FromArgb(25, 26, 28);
            Bookshelf.ItemHeight = 30;
            Bookshelf.Location = new Point(100, 473);
            Bookshelf.Name = "Bookshelf";
            Bookshelf.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Bookshelf.Size = new Size(288, 36);
            Bookshelf.Sorted = true;
            Bookshelf.TabIndex = 11;
            // 
            // UpdatedAt
            // 
            UpdatedAt.BorderRadius = 7;
            UpdatedAt.BorderThickness = 0;
            UpdatedAt.CustomizableEdges = customizableEdges3;
            UpdatedAt.DefaultText = "";
            UpdatedAt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UpdatedAt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UpdatedAt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UpdatedAt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UpdatedAt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UpdatedAt.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UpdatedAt.ForeColor = Color.FromArgb(25, 26, 28);
            UpdatedAt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UpdatedAt.Location = new Point(100, 589);
            UpdatedAt.Name = "UpdatedAt";
            UpdatedAt.PasswordChar = '\0';
            UpdatedAt.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            UpdatedAt.PlaceholderText = "UpdatedAt";
            UpdatedAt.SelectedText = "";
            UpdatedAt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            UpdatedAt.Size = new Size(288, 40);
            UpdatedAt.TabIndex = 4;
            // 
            // CreatedAt
            // 
            CreatedAt.BorderRadius = 7;
            CreatedAt.BorderThickness = 0;
            CreatedAt.CustomizableEdges = customizableEdges5;
            CreatedAt.DefaultText = "";
            CreatedAt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CreatedAt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CreatedAt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CreatedAt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CreatedAt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CreatedAt.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedAt.ForeColor = Color.FromArgb(25, 26, 28);
            CreatedAt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CreatedAt.Location = new Point(100, 529);
            CreatedAt.Name = "CreatedAt";
            CreatedAt.PasswordChar = '\0';
            CreatedAt.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            CreatedAt.PlaceholderText = "CreatedAt";
            CreatedAt.SelectedText = "";
            CreatedAt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CreatedAt.Size = new Size(288, 40);
            CreatedAt.TabIndex = 5;
            // 
            // Publisher
            // 
            Publisher.BorderRadius = 7;
            Publisher.BorderThickness = 0;
            Publisher.CustomizableEdges = customizableEdges7;
            Publisher.DefaultText = "";
            Publisher.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Publisher.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Publisher.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Publisher.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Publisher.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Publisher.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Publisher.ForeColor = Color.FromArgb(25, 26, 28);
            Publisher.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Publisher.Location = new Point(100, 413);
            Publisher.Name = "Publisher";
            Publisher.PasswordChar = '\0';
            Publisher.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            Publisher.PlaceholderText = "Publisher";
            Publisher.SelectedText = "";
            Publisher.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Publisher.Size = new Size(288, 40);
            Publisher.TabIndex = 6;
            // 
            // Price
            // 
            Price.BorderRadius = 7;
            Price.BorderThickness = 0;
            Price.CustomizableEdges = customizableEdges9;
            Price.DefaultText = "";
            Price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Price.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Price.ForeColor = Color.FromArgb(25, 26, 28);
            Price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Price.Location = new Point(100, 353);
            Price.Name = "Price";
            Price.PasswordChar = '\0';
            Price.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            Price.PlaceholderText = "Price";
            Price.SelectedText = "";
            Price.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Price.Size = new Size(288, 40);
            Price.TabIndex = 7;
            // 
            // Author
            // 
            Author.BorderRadius = 7;
            Author.BorderThickness = 0;
            Author.CustomizableEdges = customizableEdges11;
            Author.DefaultText = "";
            Author.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Author.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Author.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Author.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Author.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Author.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Author.ForeColor = Color.FromArgb(25, 26, 28);
            Author.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Author.Location = new Point(100, 293);
            Author.Name = "Author";
            Author.PasswordChar = '\0';
            Author.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            Author.PlaceholderText = "Author";
            Author.SelectedText = "";
            Author.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Author.Size = new Size(288, 40);
            Author.TabIndex = 8;
            // 
            // Code
            // 
            Code.BorderRadius = 7;
            Code.BorderThickness = 0;
            Code.CustomizableEdges = customizableEdges13;
            Code.DefaultText = "";
            Code.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Code.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Code.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Code.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Code.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Code.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Code.ForeColor = Color.FromArgb(25, 26, 28);
            Code.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Code.Location = new Point(100, 233);
            Code.Name = "Code";
            Code.PasswordChar = '\0';
            Code.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            Code.PlaceholderText = "Code";
            Code.SelectedText = "";
            Code.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Code.Size = new Size(288, 40);
            Code.TabIndex = 9;
            // 
            // Name_1
            // 
            Name_1.BorderRadius = 7;
            Name_1.BorderThickness = 0;
            Name_1.CustomizableEdges = customizableEdges15;
            Name_1.DefaultText = "";
            Name_1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Name_1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Name_1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Name_1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Name_1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Name_1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name_1.ForeColor = Color.FromArgb(25, 26, 28);
            Name_1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Name_1.IconRightSize = new Size(0, 0);
            Name_1.Location = new Point(100, 173);
            Name_1.Margin = new Padding(4, 3, 4, 3);
            Name_1.Name = "Name_1";
            Name_1.PasswordChar = '\0';
            Name_1.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            Name_1.PlaceholderText = "Name";
            Name_1.ReadOnly = true;
            Name_1.SelectedText = "";
            Name_1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Name_1.Size = new Size(288, 40);
            Name_1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 188);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 253);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 13;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 313);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 373);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 433);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 13;
            label6.Text = "Publisher";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 489);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "Bookshelf";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 549);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 13;
            label8.Text = "CreatedAt";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 609);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 13;
            label9.Text = "UpdatedAt";
            // 
            // Add_book_btn
            // 
            Add_book_btn.BackColor = Color.Transparent;
            Add_book_btn.BorderColor = Color.FromArgb(217, 217, 217);
            Add_book_btn.BorderRadius = 10;
            Add_book_btn.BorderThickness = 3;
            Add_book_btn.Cursor = Cursors.Hand;
            Add_book_btn.CustomizableEdges = customizableEdges17;
            Add_book_btn.DisabledState.BorderColor = Color.DarkGray;
            Add_book_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Add_book_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add_book_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add_book_btn.FillColor = Color.FromArgb(217, 217, 217);
            Add_book_btn.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Add_book_btn.ForeColor = Color.FromArgb(25, 26, 28);
            Add_book_btn.HoverState.BorderColor = Color.FromArgb(217, 217, 217);
            Add_book_btn.HoverState.FillColor = Color.FromArgb(25, 26, 28);
            Add_book_btn.HoverState.ForeColor = Color.FromArgb(217, 217, 217);
            Add_book_btn.Location = new Point(62, 666);
            Add_book_btn.Name = "Add_book_btn";
            Add_book_btn.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Add_book_btn.Size = new Size(300, 50);
            Add_book_btn.TabIndex = 14;
            Add_book_btn.Text = "Done";
            Add_book_btn.UseTransparentBackground = true;
            Add_book_btn.Click += Add_book_btn_Click;
            // 
            // edit_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(414, 749);
            Controls.Add(Add_book_btn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Bookshelf);
            Controls.Add(UpdatedAt);
            Controls.Add(CreatedAt);
            Controls.Add(Publisher);
            Controls.Add(Price);
            Controls.Add(Author);
            Controls.Add(Code);
            Controls.Add(Name_1);
            Controls.Add(image);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "edit_book";
            Text = "edit_book";
            FormClosing += edit_book_FormClosing_1;
            Shown += edit_book_Shown;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox Bookshelf;
        private Guna.UI2.WinForms.Guna2TextBox UpdatedAt;
        private Guna.UI2.WinForms.Guna2TextBox CreatedAt;
        private Guna.UI2.WinForms.Guna2TextBox Publisher;
        private Guna.UI2.WinForms.Guna2TextBox Price;
        private Guna.UI2.WinForms.Guna2TextBox Author;
        private Guna.UI2.WinForms.Guna2TextBox Code;
        private Guna.UI2.WinForms.Guna2TextBox Name_1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button Add_book_btn;
    }
}