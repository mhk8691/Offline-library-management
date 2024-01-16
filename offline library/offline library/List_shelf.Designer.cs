namespace offline_library
{
    partial class List_shelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_shelf));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            Edit = new Guna.UI2.WinForms.Guna2Button();
            delete = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.Green;
            listView1.Location = new Point(38, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(523, 376);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order";
            columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Id";
            columnHeader3.Width = 166;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 204, 113);
            label1.Location = new Point(187, 16);
            label1.Name = "label1";
            label1.Size = new Size(222, 43);
            label1.TabIndex = 21;
            label1.Text = "List of shelf";
            // 
            // Edit
            // 
            Edit.BackColor = Color.Transparent;
            Edit.BorderColor = Color.FromArgb(39, 174, 96);
            Edit.BorderRadius = 10;
            Edit.BorderThickness = 3;
            Edit.Cursor = Cursors.Hand;
            Edit.CustomizableEdges = customizableEdges1;
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
            Edit.Location = new Point(38, 482);
            Edit.Name = "Edit";
            Edit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Edit.Size = new Size(250, 50);
            Edit.TabIndex = 23;
            Edit.Text = "Edit shelf";
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
            delete.CustomizableEdges = customizableEdges3;
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
            delete.Location = new Point(311, 482);
            delete.Name = "delete";
            delete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            delete.Size = new Size(250, 50);
            delete.TabIndex = 24;
            delete.Text = "Delete shelf";
            delete.UseTransparentBackground = true;
            delete.Visible = false;
            delete.Click += delete_Click;
            // 
            // List_shelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(label1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "List_shelf";
            Text = "List_shelf";
            Shown += List_shelf_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button delete;
    }
}