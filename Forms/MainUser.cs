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
    public partial class MainUser : UserControl
    {
        private DataConnection _Context;
        private User _CurrentUser;
        public MainUser(User user)
        {
            InitializeComponent();
            _Context = new DataConnection();
            _CurrentUser = user;
        }

        private void MainUser_Load(object sender, EventArgs e)
        {

        }
    }
}
