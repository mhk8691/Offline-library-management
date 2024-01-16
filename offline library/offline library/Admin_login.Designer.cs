namespace offline_library
{
    partial class Admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            login_btn = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            btn_back = new PictureBox();
            Username = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).BeginInit();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Transparent;
            login_btn.BorderColor = Color.FromArgb(211, 84, 0);
            login_btn.BorderRadius = 7;
            login_btn.BorderThickness = 3;
            login_btn.Cursor = Cursors.Hand;
            login_btn.CustomizableEdges = customizableEdges1;
            login_btn.DisabledState.BorderColor = Color.DarkGray;
            login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            login_btn.FillColor = Color.FromArgb(211, 84, 0);
            login_btn.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.HoverState.BorderColor = Color.FromArgb(211, 84, 0);
            login_btn.HoverState.FillColor = Color.White;
            login_btn.HoverState.ForeColor = Color.FromArgb(211, 84, 0);
            login_btn.Location = new Point(59, 360);
            login_btn.Name = "login_btn";
            login_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            login_btn.Size = new Size(297, 46);
            login_btn.TabIndex = 11;
            login_btn.Text = "Login";
            login_btn.UseTransparentBackground = true;
            login_btn.Click += login_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.front_view_stacked_books_ladders_with_copy_space_education_day;
            pictureBox2.Location = new Point(427, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(450, 562);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // password
            // 
            password.BorderColor = Color.FromArgb(211, 84, 0);
            password.BorderRadius = 7;
            password.BorderThickness = 3;
            password.CustomizableEdges = customizableEdges3;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(211, 84, 0);
            password.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.HoverState.BorderColor = Color.FromArgb(211, 84, 0);
            password.IconLeft = Properties.Resources.padlock;
            password.IconRightOffset = new Point(6, 0);
            password.IconRightSize = new Size(26, 16);
            password.Location = new Point(59, 286);
            password.Margin = new Padding(0);
            password.Name = "password";
            password.PasswordChar = '\0';
            password.PlaceholderForeColor = Color.Gray;
            password.PlaceholderText = "Password";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password.Size = new Size(297, 46);
            password.TabIndex = 8;
            password.TextOffset = new Point(5, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 126, 34);
            label2.Location = new Point(59, 144);
            label2.Name = "label2";
            label2.Size = new Size(134, 43);
            label2.TabIndex = 6;
            label2.Text = "Admin";
            // 
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = Properties.Resources.undo;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(40, 40);
            btn_back.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back.TabIndex = 12;
            btn_back.TabStop = false;
            btn_back.Click += btn_back_Click;
            // 
            // Username
            // 
            Username.BorderColor = Color.FromArgb(211, 84, 0);
            Username.BorderRadius = 7;
            Username.BorderThickness = 3;
            Username.CustomizableEdges = customizableEdges5;
            Username.DefaultText = "";
            Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Username.FocusedState.BorderColor = Color.FromArgb(211, 84, 0);
            Username.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Username.ForeColor = Color.Black;
            Username.HoverState.BorderColor = Color.FromArgb(211, 84, 0);
            Username.IconLeft = Properties.Resources.user__2_;
            Username.IconRightOffset = new Point(6, 0);
            Username.IconRightSize = new Size(26, 16);
            Username.Location = new Point(59, 216);
            Username.Margin = new Padding(0);
            Username.Name = "Username";
            Username.PasswordChar = '\0';
            Username.PlaceholderForeColor = Color.Gray;
            Username.PlaceholderText = "User name";
            Username.SelectedText = "";
            Username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Username.Size = new Size(297, 46);
            Username.TabIndex = 8;
            Username.TextOffset = new Point(5, 0);
            // 
            // Admin_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btn_back);
            Controls.Add(login_btn);
            Controls.Add(pictureBox2);
            Controls.Add(Username);
            Controls.Add(password);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_login";
            Text = "Admin_login";
            FormClosing += Admin_login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_btn;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Label label2;
        private PictureBox btn_back;
        private Guna.UI2.WinForms.Guna2TextBox Username;
    }
}