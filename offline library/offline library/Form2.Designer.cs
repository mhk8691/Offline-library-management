namespace offline_library
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            listView1 = new ListView();
            Username = new ColumnHeader();
            UserId = new ColumnHeader();
            BookName = new ColumnHeader();
            BookCode = new ColumnHeader();
            BorrowDate = new ColumnHeader();
            ReturnDate = new ColumnHeader();
            label1 = new Label();
            Accept = new Guna.UI2.WinForms.Guna2Button();
            Reject = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Username, UserId, BookName, BookCode, BorrowDate, ReturnDate });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.FromArgb(46, 204, 113);
            listView1.Location = new Point(12, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 376);
            listView1.TabIndex = 21;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 43);
            label1.TabIndex = 22;
            label1.Text = "Request";
            // 
            // Accept
            // 
            Accept.BackColor = Color.Transparent;
            Accept.BorderColor = Color.Green;
            Accept.BorderRadius = 10;
            Accept.BorderThickness = 3;
            Accept.Cursor = Cursors.Hand;
            Accept.CustomizableEdges = customizableEdges1;
            Accept.DisabledState.BorderColor = Color.DarkGray;
            Accept.DisabledState.CustomBorderColor = Color.DarkGray;
            Accept.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Accept.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Accept.FillColor = Color.Green;
            Accept.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Accept.ForeColor = Color.White;
            Accept.HoverState.BorderColor = Color.Green;
            Accept.HoverState.FillColor = Color.FromArgb(25, 26, 28);
            Accept.HoverState.ForeColor = Color.Green;
            Accept.Location = new Point(739, 210);
            Accept.Name = "Accept";
            Accept.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Accept.Size = new Size(250, 50);
            Accept.TabIndex = 23;
            Accept.Text = "Accept";
            Accept.UseTransparentBackground = true;
            Accept.Visible = false;
            Accept.Click += Accept_Click;
            // 
            // Reject
            // 
            Reject.BackColor = Color.Transparent;
            Reject.BorderColor = Color.Red;
            Reject.BorderRadius = 10;
            Reject.BorderThickness = 3;
            Reject.Cursor = Cursors.Hand;
            Reject.CustomizableEdges = customizableEdges3;
            Reject.DisabledState.BorderColor = Color.DarkGray;
            Reject.DisabledState.CustomBorderColor = Color.DarkGray;
            Reject.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reject.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reject.FillColor = Color.Red;
            Reject.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Reject.ForeColor = Color.White;
            Reject.HoverState.BorderColor = Color.Red;
            Reject.HoverState.FillColor = Color.FromArgb(25, 26, 28);
            Reject.HoverState.ForeColor = Color.Red;
            Reject.Location = new Point(739, 275);
            Reject.Name = "Reject";
            Reject.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Reject.Size = new Size(250, 50);
            Reject.TabIndex = 24;
            Reject.Text = "Reject";
            Reject.UseTransparentBackground = true;
            Reject.Visible = false;
            Reject.Click += Reject_Click;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(1001, 500);
            Controls.Add(Reject);
            Controls.Add(Accept);
            Controls.Add(label1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Request";
            Text = "Form2";
            Shown += Request_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Username;
        private ColumnHeader UserId;
        private ColumnHeader BookName;
        private ColumnHeader BookCode;
        private ColumnHeader BorrowDate;
        private ColumnHeader ReturnDate;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button Accept;
        private Guna.UI2.WinForms.Guna2Button Reject;
    }
}