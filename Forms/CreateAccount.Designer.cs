namespace RestoSMK.Forms
{
    partial class CreateAccount
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
            txt_name = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            label4 = new Label();
            txt_phone = new TextBox();
            label5 = new Label();
            txt_alamat = new TextBox();
            label6 = new Label();
            link_login = new LinkLabel();
            check_pw = new CheckBox();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 29);
            label1.Name = "label1";
            label1.Size = new Size(273, 47);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(12, 117);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(360, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(12, 173);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(360, 23);
            txt_name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 228);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(360, 23);
            txt_password.TabIndex = 6;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(12, 289);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(360, 23);
            txt_phone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 271);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "No HP";
            // 
            // txt_alamat
            // 
            txt_alamat.Location = new Point(12, 353);
            txt_alamat.Name = "txt_alamat";
            txt_alamat.Size = new Size(360, 23);
            txt_alamat.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 335);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 9;
            label6.Text = "Adresses";
            // 
            // link_login
            // 
            link_login.AutoSize = true;
            link_login.Location = new Point(12, 396);
            link_login.Name = "link_login";
            link_login.Size = new Size(68, 15);
            link_login.TabIndex = 11;
            link_login.TabStop = true;
            link_login.Text = "Login Form";
            link_login.LinkClicked += link_login_LinkClicked;
            // 
            // check_pw
            // 
            check_pw.AutoSize = true;
            check_pw.Location = new Point(264, 396);
            check_pw.Name = "check_pw";
            check_pw.Size = new Size(108, 19);
            check_pw.TabIndex = 12;
            check_pw.Text = "Show Password";
            check_pw.UseVisualStyleBackColor = true;
            check_pw.CheckedChanged += check_pw_CheckedChanged;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(12, 438);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(360, 40);
            btn_register.TabIndex = 13;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(384, 511);
            Controls.Add(btn_register);
            Controls.Add(check_pw);
            Controls.Add(link_login);
            Controls.Add(txt_alamat);
            Controls.Add(label6);
            Controls.Add(txt_phone);
            Controls.Add(label5);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_name;
        private Label label3;
        private TextBox txt_password;
        private Label label4;
        private TextBox txt_phone;
        private Label label5;
        private TextBox txt_alamat;
        private Label label6;
        private LinkLabel link_login;
        private CheckBox check_pw;
        private Button btn_register;
    }
}