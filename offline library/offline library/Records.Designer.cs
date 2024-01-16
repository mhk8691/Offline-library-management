namespace offline_library
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            label1 = new Label();
            Username = new ColumnHeader();
            UserId = new ColumnHeader();
            BookName = new ColumnHeader();
            BookCode = new ColumnHeader();
            BorrowDate = new ColumnHeader();
            ReturnDate = new ColumnHeader();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 43);
            label1.TabIndex = 21;
            label1.Text = "Users History";
            // 
            // Username
            // 
            Username.Text = "User name";
            Username.Width = 100;
            // 
            // UserId
            // 
            UserId.Text = "User Id";
            UserId.TextAlign = HorizontalAlignment.Center;
            UserId.Width = 70;
            // 
            // BookName
            // 
            BookName.Text = "Book Name";
            BookName.TextAlign = HorizontalAlignment.Center;
            BookName.Width = 110;
            // 
            // BookCode
            // 
            BookCode.Text = "Book Code";
            BookCode.TextAlign = HorizontalAlignment.Center;
            BookCode.Width = 100;
            // 
            // BorrowDate
            // 
            BorrowDate.Text = "Borrow Date";
            BorrowDate.TextAlign = HorizontalAlignment.Center;
            BorrowDate.Width = 150;
            // 
            // ReturnDate
            // 
            ReturnDate.Text = "Return Date";
            ReturnDate.Width = 180;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Username, UserId, BookName, BookCode, BorrowDate, ReturnDate });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.FromArgb(46, 204, 113);
            listView1.Location = new Point(29, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 376);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(884, 484);
            Controls.Add(label1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Records";
            Text = "Records";
            Shown += Records_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ColumnHeader Username;
        private ColumnHeader UserId;
        private ColumnHeader BookName;
        private ColumnHeader BookCode;
        private ColumnHeader BorrowDate;
        private ColumnHeader ReturnDate;
        private ListView listView1;
    }
}