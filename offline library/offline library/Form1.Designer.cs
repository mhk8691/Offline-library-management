namespace offline_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login_btn = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            Admin_btn = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Transparent;
            Login_btn.BorderColor = Color.White;
            Login_btn.BorderRadius = 12;
            Login_btn.BorderThickness = 3;
            Login_btn.Cursor = Cursors.Hand;
            Login_btn.CustomBorderColor = Color.White;
            Login_btn.CustomizableEdges = customizableEdges1;
            Login_btn.DisabledState.BorderColor = Color.DarkGray;
            Login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Login_btn.FillColor = Color.FromArgb(128, 0, 255);
            Login_btn.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login_btn.ForeColor = Color.White;
            Login_btn.HoverState.BorderColor = Color.FromArgb(128, 0, 255);
            Login_btn.HoverState.FillColor = Color.White;
            Login_btn.HoverState.ForeColor = Color.FromArgb(128, 0, 255);
            Login_btn.Location = new Point(16, 180);
            Login_btn.Name = "Login_btn";
            Login_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Login_btn.Size = new Size(350, 50);
            Login_btn.TabIndex = 1;
            Login_btn.Text = "Login";
            Login_btn.UseTransparentBackground = true;
            Login_btn.Visible = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.open_book;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Admin_btn
            // 
            Admin_btn.BackColor = Color.Transparent;
            Admin_btn.BorderColor = Color.FromArgb(128, 0, 255);
            Admin_btn.BorderRadius = 12;
            Admin_btn.BorderThickness = 3;
            Admin_btn.Cursor = Cursors.Hand;
            Admin_btn.CustomBorderColor = Color.White;
            Admin_btn.CustomizableEdges = customizableEdges3;
            Admin_btn.DisabledState.BorderColor = Color.DarkGray;
            Admin_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Admin_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Admin_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Admin_btn.FillColor = SystemColors.Window;
            Admin_btn.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Admin_btn.ForeColor = Color.FromArgb(128, 0, 255);
            Admin_btn.HoverState.BorderColor = Color.White;
            Admin_btn.HoverState.FillColor = Color.FromArgb(128, 0, 255);
            Admin_btn.HoverState.ForeColor = Color.White;
            Admin_btn.Location = new Point(16, 250);
            Admin_btn.Name = "Admin_btn";
            Admin_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Admin_btn.Size = new Size(350, 50);
            Admin_btn.TabIndex = 1;
            Admin_btn.Text = "Admin";
            Admin_btn.UseTransparentBackground = true;
            Admin_btn.Visible = false;
            Admin_btn.Click += Admin_btn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // ProgressBar1
            // 
            ProgressBar1.BackColor = Color.Transparent;
            ProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            ProgressBar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressBar1.ForeColor = Color.White;
            ProgressBar1.Location = new Point(124, 160);
            ProgressBar1.Minimum = 0;
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.ProgressColor = Color.FromArgb(0, 192, 0);
            ProgressBar1.ProgressColor2 = Color.FromArgb(0, 192, 0);
            ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressBar1.Size = new Size(151, 151);
            ProgressBar1.TabIndex = 3;
            ProgressBar1.Text = "guna2CircleProgressBar1";
            ProgressBar1.UseTransparentBackground = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(384, 561);
            Controls.Add(ProgressBar1);
            Controls.Add(Admin_btn);
            Controls.Add(Login_btn);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Login_btn;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Admin_btn;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar1;
    }
}
