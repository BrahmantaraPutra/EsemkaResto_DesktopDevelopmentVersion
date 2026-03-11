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
    public partial class CreateAccount : Form
    {
        private DataConnection _Context;
        public CreateAccount()
        {
            InitializeComponent();
            _Context = new DataConnection();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void check_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pw.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }

            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String Email = txt_email.Text;
            String Password = txt_password.Text;
            String Nama = txt_name.Text;
            String NoHp = txt_phone.Text;
            String Alamat = txt_alamat.Text;
            
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Nama) || string.IsNullOrEmpty(NoHp))
            {
                MessageBox.Show("Email, Password, Nama, dan No Hp tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newuser = new User
            {
                Email = Email,
                Password = Password,
                Nama = Nama,
                NoHp = NoHp,
                Alamat = Alamat,
                CreateAt = DateTime.Now,
                Status = "pelanggan"
            };

            _Context.Users.Add(newuser);
            _Context.SaveChanges();

            MessageBox.Show("Akun berhasil dibuat!, Silahkan Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();

        }
    }
}
