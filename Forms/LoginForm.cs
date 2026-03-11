using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestoSMK.Data;
using RestoSMK.Models;


namespace RestoSMK.Forms
{
    public partial class LoginForm : Form
    {
        private DataConnection _Context;

        public LoginForm()
        {
            InitializeComponent();
            _Context = new DataConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Email = txt_email.Text;
            string Password = txt_password.Text;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var User = _Context.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (User != null)
            {
                MessageBox.Show("Login Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(User);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }

            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
