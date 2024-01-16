namespace offline_library
{
    partial class Reclaime
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
            label1 = new Label();
            listView1 = new ListView();
            Username = new ColumnHeader();
            UserId = new ColumnHeader();
            BookName = new ColumnHeader();
            BookCode = new ColumnHeader();
            BorrowDate = new ColumnHeader();
            ReturnDate = new ColumnHeader();
            Reclaime_btn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(192, 43);
            label1.TabIndex = 23;
            label1.Text = "ReClaime";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Username, UserId, BookName, BookCode, BorrowDate, ReturnDate });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.FromArgb(46, 204, 113);
            listView1.Location = new Point(12, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 376);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // Reclaime_btn
            // 
            Reclaime_btn.BackColor = Color.Transparent;
            Reclaime_btn.BorderColor = Color.FromArgb(39, 174, 96);
            Reclaime_btn.BorderRadius = 10;
            Reclaime_btn.BorderThickness = 3;
            Reclaime_btn.Cursor = Cursors.Hand;
            Reclaime_btn.CustomizableEdges = customizableEdges1;
            Reclaime_btn.DisabledState.BorderColor = Color.DarkGray;
            Reclaime_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Reclaime_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reclaime_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reclaime_btn.FillColor = Color.FromArgb(39, 174, 96);
            Reclaime_btn.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Reclaime_btn.ForeColor = Color.White;
            Reclaime_btn.HoverState.BorderColor = Color.FromArgb(39, 174, 96);
            Reclaime_btn.HoverState.FillColor = Color.White;
            Reclaime_btn.HoverState.ForeColor = Color.FromArgb(39, 174, 96);
            Reclaime_btn.Image = Properties.Resources.down_arrow;
            Reclaime_btn.ImageAlign = HorizontalAlignment.Left;
            Reclaime_btn.ImageSize = new Size(30, 30);
            Reclaime_btn.Location = new Point(12, 476);
            Reclaime_btn.Name = "Reclaime_btn";
            Reclaime_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Reclaime_btn.Size = new Size(300, 50);
            Reclaime_btn.TabIndex = 24;
            Reclaime_btn.Text = "Reclaime";
            Reclaime_btn.UseTransparentBackground = true;
            Reclaime_btn.Visible = false;
            Reclaime_btn.Click += Reclaime_btn_Click;
            // 
            // Reclaime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(884, 543);
            Controls.Add(Reclaime_btn);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Reclaime";
            Text = "Reclaime";
            Shown += Reclaime_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Username;
        private ColumnHeader UserId;
        private ColumnHeader BookName;
        private ColumnHeader BookCode;
        private ColumnHeader BorrowDate;
        private ColumnHeader ReturnDate;
        private Guna.UI2.WinForms.Guna2Button Reclaime_btn;
    }
}