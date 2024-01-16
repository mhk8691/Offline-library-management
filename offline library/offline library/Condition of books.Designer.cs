namespace offline_library
{
    partial class Condition_of_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condition_of_books));
            tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            Loan_books = new TabPage();
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
            label1 = new Label();
            Available_books = new TabPage();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label2 = new Label();
            tabControl.SuspendLayout();
            Loan_books.SuspendLayout();
            Available_books.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.Controls.Add(Loan_books);
            tabControl.Controls.Add(Available_books);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.ImeMode = ImeMode.NoControl;
            tabControl.ItemSize = new Size(180, 40);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1034, 461);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonHoverState.ForeColor = Color.White;
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonSelectedState.ForeColor = Color.White;
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(180, 40);
            tabControl.TabIndex = 3;
            tabControl.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // Loan_books
            // 
            Loan_books.Controls.Add(listView1);
            Loan_books.Controls.Add(label1);
            Loan_books.Location = new Point(184, 4);
            Loan_books.Name = "Loan_books";
            Loan_books.Padding = new Padding(3);
            Loan_books.Size = new Size(846, 453);
            Loan_books.TabIndex = 0;
            Loan_books.Text = "Loan books";
            Loan_books.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name1, Code, Id, Author, Price, Publisher, Bookshelf, CreatedAt, UpdatedAt, Status });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.Green;
            listView1.Location = new Point(8, 52);
            listView1.Name = "listView1";
            listView1.Size = new Size(830, 376);
            listView1.TabIndex = 22;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(26, 188, 156);
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(225, 44);
            label1.TabIndex = 5;
            label1.Text = "Loan books";
            // 
            // Available_books
            // 
            Available_books.Controls.Add(listView2);
            Available_books.Controls.Add(label2);
            Available_books.Location = new Point(184, 4);
            Available_books.Name = "Available_books";
            Available_books.Padding = new Padding(3);
            Available_books.Size = new Size(846, 453);
            Available_books.TabIndex = 1;
            Available_books.Text = "Available books";
            Available_books.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4 });
            listView2.Location = new Point(51, 70);
            listView2.Name = "listView2";
            listView2.Size = new Size(600, 347);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Book name";
            columnHeader2.Width = 290;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Book Code";
            columnHeader4.Width = 290;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(26, 188, 156);
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(307, 44);
            label2.TabIndex = 4;
            label2.Text = "Available books";
            // 
            // Condition_of_books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(1034, 461);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Condition_of_books";
            Text = "Condition_of_books";
            Load += Condition_of_books_Load;
            tabControl.ResumeLayout(false);
            Loan_books.ResumeLayout(false);
            Loan_books.PerformLayout();
            Available_books.ResumeLayout(false);
            Available_books.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private TabPage Loan_books;
        private TabPage Available_books;
        private Label label2;
        private Label label1;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
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