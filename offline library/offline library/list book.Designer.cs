namespace offline_library
{
    partial class List_book
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_book));
            Edit = new Guna.UI2.WinForms.Guna2Button();
            delete = new Guna.UI2.WinForms.Guna2Button();
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
            btn_back = new PictureBox();
            label1 = new Label();
            image_book = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image_book).BeginInit();
            SuspendLayout();
            // 
            // Edit
            // 
            Edit.BackColor = Color.Transparent;
            Edit.BorderColor = Color.FromArgb(39, 174, 96);
            Edit.BorderRadius = 10;
            Edit.BorderThickness = 3;
            Edit.Cursor = Cursors.Hand;
            Edit.CustomizableEdges = customizableEdges5;
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
            Edit.Location = new Point(12, 499);
            Edit.Name = "Edit";
            Edit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Edit.Size = new Size(300, 50);
            Edit.TabIndex = 20;
            Edit.Text = "Edit book";
            Edit.UseTransparentBackground = true;
            Edit.Visible = false;
            Edit.Click += Edit_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Transparent;
            delete.BorderColor = Color.FromArgb(39, 174, 96);
            delete.BorderRadius = 10;
            delete.BorderThickness = 3;
            delete.Cursor = Cursors.Hand;
            delete.CustomizableEdges = customizableEdges7;
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
            delete.ImageAlign = HorizontalAlignment.Left;
            delete.ImageSize = new Size(30, 30);
            delete.Location = new Point(334, 499);
            delete.Name = "delete";
            delete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            delete.Size = new Size(300, 50);
            delete.TabIndex = 22;
            delete.Text = "Delete book";
            delete.UseTransparentBackground = true;
            delete.Visible = false;
            delete.Click += delete_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name1, Code, Id, Author, Price, Publisher, Bookshelf, CreatedAt, UpdatedAt, Status });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.Green;
            listView1.Location = new Point(12, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(830, 376);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = Properties.Resources.undo;
            btn_back.Location = new Point(-55, 16);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(40, 40);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 18;
            btn_back.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(371, 16);
            label1.Name = "label1";
            label1.Size = new Size(248, 43);
            label1.TabIndex = 17;
            label1.Text = "List of Books";
            // 
            // image_book
            // 
            image_book.Location = new Point(880, 78);
            image_book.Name = "image_book";
            image_book.Size = new Size(100, 100);
            image_book.SizeMode = PictureBoxSizeMode.StretchImage;
            image_book.TabIndex = 23;
            image_book.TabStop = false;
            image_book.Visible = false;
            // 
            // List_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(image_book);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(listView1);
            Controls.Add(btn_back);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "List_book";
            Text = "list_book";
            Load += List_book_Load;
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)image_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button delete;
        private ListView listView1;
        private ColumnHeader Name1;
        private ColumnHeader Code;
        private ColumnHeader Author;
        private ColumnHeader Price;
        private ColumnHeader Publisher;
        private ColumnHeader Bookshelf;
        private ColumnHeader CreatedAt;
        private ColumnHeader UpdatedAt;
        private ColumnHeader Status;
        private ColumnHeader Id;
        private PictureBox btn_back;
        private Label label1;
        private ColumnHeader UserName;
        private PictureBox image_book;
    }
}