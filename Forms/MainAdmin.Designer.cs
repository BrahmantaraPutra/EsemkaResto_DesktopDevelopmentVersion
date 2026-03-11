namespace RestoSMK.Forms
{
    partial class MainAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_sidebar = new Panel();
            panel3 = new Panel();
            txt_username = new Label();
            pictureBox1 = new PictureBox();
            manajement_menu = new Label();
            dashboard_menu = new Label();
            pelunasan_menu = new Label();
            manajement_meja = new Label();
            panel_content = new Panel();
            panel_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = SystemColors.ControlLight;
            panel_sidebar.Controls.Add(panel3);
            panel_sidebar.Controls.Add(manajement_menu);
            panel_sidebar.Controls.Add(dashboard_menu);
            panel_sidebar.Controls.Add(pelunasan_menu);
            panel_sidebar.Controls.Add(manajement_meja);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(200, 861);
            panel_sidebar.TabIndex = 0;
            panel_sidebar.Paint += panel_sidebar_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_username);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 50);
            panel3.TabIndex = 5;
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(43, 20);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(69, 17);
            txt_username.TabIndex = 1;
            txt_username.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // manajement_menu
            // 
            manajement_menu.AutoSize = true;
            manajement_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manajement_menu.Location = new Point(12, 118);
            manajement_menu.Name = "manajement_menu";
            manajement_menu.Size = new Size(172, 25);
            manajement_menu.TabIndex = 9;
            manajement_menu.Text = "Manajement Menu";
            manajement_menu.Click += manajement_menu_Click_2;
            // 
            // dashboard_menu
            // 
            dashboard_menu.AutoSize = true;
            dashboard_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_menu.Location = new Point(14, 199);
            dashboard_menu.Name = "dashboard_menu";
            dashboard_menu.Size = new Size(104, 25);
            dashboard_menu.TabIndex = 8;
            dashboard_menu.Text = "Dashboard";
            dashboard_menu.Click += dashboard_menu_Click_1;
            // 
            // pelunasan_menu
            // 
            pelunasan_menu.AutoSize = true;
            pelunasan_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pelunasan_menu.Location = new Point(14, 158);
            pelunasan_menu.Name = "pelunasan_menu";
            pelunasan_menu.Size = new Size(77, 25);
            pelunasan_menu.TabIndex = 7;
            pelunasan_menu.Text = "Riwayat";
            pelunasan_menu.Click += pelunasan_menu_Click_1;
            // 
            // manajement_meja
            // 
            manajement_meja.AutoSize = true;
            manajement_meja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manajement_meja.Location = new Point(12, 76);
            manajement_meja.Name = "manajement_meja";
            manajement_meja.Size = new Size(165, 25);
            manajement_meja.TabIndex = 6;
            manajement_meja.Text = "Manajement Meja";
            manajement_meja.Click += manajement_meja_Click;
            // 
            // panel_content
            // 
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(200, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(984, 861);
            panel_content.TabIndex = 1;
            panel_content.Paint += panel_content_Paint;
            // 
            // MainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_content);
            Controls.Add(panel_sidebar);
            Name = "MainAdmin";
            Size = new Size(1184, 861);
            panel_sidebar.ResumeLayout(false);
            panel_sidebar.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Panel panel3;
        private Label txt_username;
        private PictureBox pictureBox1;
        private Label manajement_menu;
        private Label dashboard_menu;
        private Label pelunasan_menu;
        private Label manajement_meja;
        private Panel panel_content;
    }
}
