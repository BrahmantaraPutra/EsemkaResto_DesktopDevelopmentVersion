namespace RestoSMK.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            checkBox1 = new CheckBox();
            link_create = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 32);
            label1.Name = "label1";
            label1.Size = new Size(235, 47);
            label1.TabIndex = 0;
            label1.Text = "EsemkaResto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(12, 129);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(360, 23);
            txt_email.TabIndex = 2;
            txt_email.TextChanged += textBox1_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 191);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(360, 23);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(12, 288);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(360, 40);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(264, 231);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // link_create
            // 
            link_create.AutoSize = true;
            link_create.Location = new Point(12, 231);
            link_create.Name = "link_create";
            link_create.Size = new Size(89, 15);
            link_create.TabIndex = 7;
            link_create.TabStop = true;
            link_create.Text = "Create Account";
            link_create.LinkClicked += link_create_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(link_create);
            Controls.Add(checkBox1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_password;
        private Label label3;
        private Button btn_login;
        private CheckBox checkBox1;
        private LinkLabel link_create;
    }
}