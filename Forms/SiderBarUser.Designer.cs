namespace RestoSMK.Forms
{
    partial class SiderBarUser
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
            manajement_menu = new Label();
            dashboard_menu = new Label();
            pelunasan_menu = new Label();
            manajement_meja = new Label();
            panel1 = new Panel();
            txt_username = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // manajement_menu
            // 
            manajement_menu.AutoSize = true;
            manajement_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manajement_menu.Location = new Point(12, 148);
            manajement_menu.Name = "manajement_menu";
            manajement_menu.Size = new Size(172, 25);
            manajement_menu.TabIndex = 9;
            manajement_menu.Text = "Manajement Menu";
            // 
            // dashboard_menu
            // 
            dashboard_menu.AutoSize = true;
            dashboard_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_menu.Location = new Point(14, 229);
            dashboard_menu.Name = "dashboard_menu";
            dashboard_menu.Size = new Size(104, 25);
            dashboard_menu.TabIndex = 8;
            dashboard_menu.Text = "Dashboard";
            // 
            // pelunasan_menu
            // 
            pelunasan_menu.AutoSize = true;
            pelunasan_menu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pelunasan_menu.Location = new Point(14, 188);
            pelunasan_menu.Name = "pelunasan_menu";
            pelunasan_menu.Size = new Size(98, 25);
            pelunasan_menu.TabIndex = 7;
            pelunasan_menu.Text = "Pelunasan";
            // 
            // manajement_meja
            // 
            manajement_meja.AutoSize = true;
            manajement_meja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manajement_meja.Location = new Point(12, 106);
            manajement_meja.Name = "manajement_meja";
            manajement_meja.Size = new Size(165, 25);
            manajement_meja.TabIndex = 6;
            manajement_meja.Text = "Manajement Meja";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 50);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
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
            // 
            // SiderBarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(manajement_menu);
            Controls.Add(dashboard_menu);
            Controls.Add(pelunasan_menu);
            Controls.Add(manajement_meja);
            Controls.Add(panel1);
            Name = "SiderBarUser";
            Size = new Size(200, 861);
            Load += SiderBarUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label manajement_menu;
        private Label dashboard_menu;
        private Label pelunasan_menu;
        private Label manajement_meja;
        private Panel panel1;
        private Label txt_username;
        private PictureBox pictureBox1;
    }
}
