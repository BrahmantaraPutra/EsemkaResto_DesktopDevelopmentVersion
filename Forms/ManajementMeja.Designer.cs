namespace RestoSMK.Forms
{
    partial class ManajementMeja
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
            label1 = new Label();
            dg_meja = new DataGridView();
            groupBox1 = new GroupBox();
            btn_save = new Button();
            status = new ComboBox();
            label5 = new Label();
            kapasitas = new NumericUpDown();
            label4 = new Label();
            no_meja = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_meja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kapasitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)no_meja).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 0;
            label1.Text = "List Meja";
            // 
            // dg_meja
            // 
            dg_meja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_meja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_meja.Location = new Point(13, 60);
            dg_meja.Margin = new Padding(0);
            dg_meja.Name = "dg_meja";
            dg_meja.Size = new Size(632, 646);
            dg_meja.TabIndex = 1;
            dg_meja.CellContentClick += dg_meja_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(status);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(kapasitas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(no_meja);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(669, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 256);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
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
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Location = new Point(107, 154);
            status.Name = "status";
            status.Size = new Size(177, 23);
            status.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 162);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Status";
            // 
            // kapasitas
            // 
            kapasitas.Location = new Point(107, 118);
            kapasitas.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            kapasitas.Name = "kapasitas";
            kapasitas.Size = new Size(177, 23);
            kapasitas.TabIndex = 4;
            kapasitas.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Kapasitas";
            label4.Click += label4_Click;
            // 
            // no_meja
            // 
            no_meja.Location = new Point(107, 84);
            no_meja.Name = "no_meja";
            no_meja.Size = new Size(177, 23);
            no_meja.TabIndex = 2;
            no_meja.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "No Meja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(234, 45);
            label2.TabIndex = 0;
            label2.Text = "Tambah Meja";
            // 
            // button1
            // 
            button1.Location = new Point(518, 721);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 721);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 4;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ManajementMeja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dg_meja);
            Controls.Add(label1);
            Name = "ManajementMeja";
            Padding = new Padding(10);
            Size = new Size(984, 861);
            Load += ManajementMeja_Load;
            ((System.ComponentModel.ISupportInitialize)dg_meja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kapasitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)no_meja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dg_meja;
        private GroupBox groupBox1;
        private Label label4;
        private NumericUpDown no_meja;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button btn_save;
        private ComboBox status;
        private Label label5;
        private NumericUpDown kapasitas;
    }
}
