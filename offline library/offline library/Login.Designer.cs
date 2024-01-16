namespace offline_library
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox2 = new PictureBox();
            login_btn = new Guna.UI2.WinForms.Guna2Button();
            btn_back = new PictureBox();
            username = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(26, 188, 156);
            label2.Location = new Point(66, 144);
            label2.Name = "label2";
            label2.Size = new Size(118, 43);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // password
            // 
            password.BorderColor = Color.FromArgb(22, 160, 133);
            password.BorderRadius = 7;
            password.BorderThickness = 3;
            password.CustomizableEdges = customizableEdges1;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(22, 160, 133);
            password.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            password.IconLeft = Properties.Resources.padlock;
            password.IconRightOffset = new Point(6, 0);
            password.IconRightSize = new Size(26, 16);
            password.Location = new Point(66, 286);
            password.Margin = new Padding(0);
            password.Name = "password";
            password.PasswordChar = '\0';
            password.PlaceholderForeColor = Color.Gray;
            password.PlaceholderText = "Password";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges2;
            password.Size = new Size(297, 46);
            password.TabIndex = 2;
            password.TextOffset = new Point(5, 0);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tswv_dzjb_230710;
            pictureBox2.Location = new Point(434, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(450, 562);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Transparent;
            login_btn.BorderColor = Color.FromArgb(22, 160, 133);
            login_btn.BorderRadius = 7;
            login_btn.BorderThickness = 3;
            login_btn.Cursor = Cursors.Hand;
            login_btn.CustomizableEdges = customizableEdges3;
            login_btn.DisabledState.BorderColor = Color.DarkGray;
            login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            login_btn.FillColor = Color.FromArgb(22, 160, 133);
            login_btn.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            login_btn.HoverState.FillColor = Color.White;
            login_btn.HoverState.ForeColor = Color.FromArgb(22, 160, 133);
            login_btn.Location = new Point(66, 360);
            login_btn.Name = "login_btn";
            login_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            login_btn.Size = new Size(297, 46);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseTransparentBackground = true;
            login_btn.Click += login_btn_Click;
            // 
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = Properties.Resources.undo;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(40, 40);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 13;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // username
            // 
            username.BorderColor = Color.FromArgb(22, 160, 133);
            username.BorderRadius = 7;
            username.BorderThickness = 3;
            username.CustomizableEdges = customizableEdges5;
            username.DefaultText = "";
            username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username.FocusedState.BorderColor = Color.FromArgb(22, 160, 133);
            username.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Black;
            username.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            username.IconLeft = Properties.Resources.user__2_;
            username.IconRightOffset = new Point(6, 0);
            username.IconRightSize = new Size(26, 16);
            username.Location = new Point(66, 216);
            username.Margin = new Padding(0);
            username.Name = "username";
            username.PasswordChar = '\0';
            username.PlaceholderForeColor = Color.Gray;
            username.PlaceholderText = "User name";
            username.SelectedText = "";
            username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            username.Size = new Size(297, 46);
            username.TabIndex = 2;
            username.TextOffset = new Point(5, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.undo;
            pictureBox1.Location = new Point(12, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btn_back_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            Controls.Add(login_btn);
            Controls.Add(username);
            Controls.Add(pictureBox2);
            Controls.Add(password);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private PictureBox btn_back;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private PictureBox pictureBox1;
    }
}