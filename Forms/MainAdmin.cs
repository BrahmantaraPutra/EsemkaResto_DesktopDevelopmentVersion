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
    public partial class MainAdmin : UserControl
    {
        private DataConnection _Context;
        private User _CurrentUser;
        public MainAdmin(User user)
        {
            InitializeComponent();
            _Context = new DataConnection();
            _CurrentUser = user;
            txt_username.Text = _CurrentUser.Nama;
            SetActive(manajement_meja);
            loadcontent(new ManajementMeja(_CurrentUser));
        }
        private void loadcontent(UserControl control)
        {
            panel_content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            panel_content.Controls.Add(control);
        }
        private void panel_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void SiderBarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetmenu()
        {
            dashboard_menu.Font = new Font(dashboard_menu.Font, FontStyle.Regular);
            manajement_meja.Font = new Font(manajement_meja.Font, FontStyle.Regular);
            pelunasan_menu.Font = new Font(pelunasan_menu.Font, FontStyle.Regular);
            manajement_menu.Font = new Font(manajement_menu.Font, FontStyle.Regular);
        }

        private void SetActive(Label menu)
        {
            resetmenu();
            menu.Font = new Font(menu.Font, FontStyle.Bold);
        }

        private void pelunasan_menu_Click(object sender, EventArgs e)
        {
            SetActive(pelunasan_menu);

        }

        private void manajement_menu_Click(object sender, EventArgs e)
        {
            SetActive(manajement_meja);
        }

        private void dashboard_menu_Click(object sender, EventArgs e)
        {
            SetActive(dashboard_menu);
        }

        private void manajement_menu_Click_1(object sender, EventArgs e)
        {
            SetActive(manajement_menu);
        }

        private void manajement_meja_Click(object sender, EventArgs e)
        {
            SetActive(manajement_meja);
            loadcontent(new ManajementMeja(_CurrentUser));
        }

        private void manajement_menu_Click_2(object sender, EventArgs e)
        {
            SetActive(manajement_menu);
            loadcontent(new ManajementMenu(_CurrentUser));
        }

        private void pelunasan_menu_Click_1(object sender, EventArgs e)
        {
            SetActive(pelunasan_menu);
        }

        private void dashboard_menu_Click_1(object sender, EventArgs e)
        {
            SetActive(dashboard_menu);
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
