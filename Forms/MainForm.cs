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
    public partial class MainForm : Form
    {
        private DataConnection _Context;
        private User _CurrentUser;
        public MainForm(User user)
        {
            InitializeComponent();
            _Context = new DataConnection();
            _CurrentUser = user;

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_CurrentUser.Status == "admin")
            {
                MainAdmin mainAdmin = new MainAdmin(_CurrentUser);
                panel_content.Controls.Clear();
                panel_content.Controls.Add(mainAdmin);
            }
            else
            {
                MainUser mainUser = new MainUser(_CurrentUser);
                panel_content.Controls.Clear();
                panel_content.Controls.Add(mainUser);
            }
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_content_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
