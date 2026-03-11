namespace RestoSMK.Forms
{
    partial class ManajementMenu
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
            groupBox1 = new GroupBox();
            harga = new NumericUpDown();
            txt_menu = new TextBox();
            btn_save = new Button();
            label5 = new Label();
            stok = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dg_menu = new DataGridView();
            label1 = new Label();
            btn_edit = new Button();
            btn_delete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)harga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_menu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(harga);
            groupBox1.Controls.Add(txt_menu);
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(stok);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(669, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 256);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // harga
            // 
            harga.Location = new Point(107, 154);
            harga.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            harga.Name = "harga";
            harga.Size = new Size(177, 23);
            harga.TabIndex = 9;
            harga.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_menu
            // 
            txt_menu.Location = new Point(107, 84);
            txt_menu.Name = "txt_menu";
            txt_menu.Size = new Size(177, 23);
            txt_menu.TabIndex = 8;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(20, 194);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(264, 41);
            btn_save.TabIndex = 7;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 162);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Harga";
            // 
            // stok
            // 
            stok.Location = new Point(107, 118);
            stok.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            stok.Name = "stok";
            stok.Size = new Size(177, 23);
            stok.TabIndex = 4;
            stok.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 92);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Nama Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(246, 45);
            label2.TabIndex = 0;
            label2.Text = "Tambah Menu";
            // 
            // dg_menu
            // 
            dg_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_menu.Location = new Point(13, 96);
            dg_menu.Margin = new Padding(0);
            dg_menu.Name = "dg_menu";
            dg_menu.Size = new Size(632, 646);
            dg_menu.TabIndex = 6;
            dg_menu.CellContentClick += dg_meja_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(152, 40);
            label1.TabIndex = 5;
            label1.Text = "List Menu";
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(385, 757);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(127, 38);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(518, 757);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(127, 38);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // ManajementMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(dg_menu);
            Controls.Add(label1);
            Controls.Add(btn_edit);
            Controls.Add(btn_delete);
            Name = "ManajementMenu";
            Padding = new Padding(30);
            Size = new Size(984, 861);
            Load += ManajementMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)harga).EndInit();
            ((System.ComponentModel.ISupportInitialize)stok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_save;
        private Label label5;
        private NumericUpDown stok;
        private Label label4;
        private Label label3;
        private Label label2;
        public DataGridView dg_menu;
        private Label label1;
        private Button btn_edit;
        private Button btn_delete;
        private TextBox txt_menu;
        private NumericUpDown harga;
    }
}
