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
    public partial class ManajementMenu : UserControl
    {
        private DataConnection _Context;
        private User _CurrentUser;
        private int _selectedMenuId = 0;

        public ManajementMenu(User user)
        {
            InitializeComponent();
            _Context = new DataConnection();
            _CurrentUser = user;
            loadmeja();
        }

        private void loadmeja()
        {
            var menuList = _Context.Menus
            .Select(m => new
            {
                m.MenuId,
                m.NamaMenu,
                m.Harga,
                m.Stock
            })
            .ToList();
            dg_menu.DataSource = menuList;
        }

        private void ManajementMenu_Load(object sender, EventArgs e)
        {

        }

        private void dg_meja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_menu.Text))
            {
                MessageBox.Show("Nama menu tidak boleh kosong!");
                return;
            }

            Menu menu;

            if (_selectedMenuId == 0)
            {
                menu = new Menu();
                _Context.Menus.Add(menu);
            }

            else
            {
                menu = _Context.Menus.Find(_selectedMenuId);
                if (menu == null) return;
            }

            menu.NamaMenu = txt_menu.Text;
            menu.Harga = harga.Value;
            menu.Stock = (int)stok.Value;

            _Context.SaveChanges();

            ClearForm();
            loadmeja();

            MessageBox.Show("Data menu berhasil disimpan!");
        }

        private void ClearForm()
        {
            txt_menu.Clear();
            harga.Value = 0;
            stok.Value = 0;
            _selectedMenuId = 0;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dg_menu.CurrentRow == null) return;

            var row = dg_menu.CurrentRow;

            _selectedMenuId = (int)row.Cells["MenuId"].Value;
            txt_menu.Text = row.Cells["NamaMenu"].Value.ToString();
            harga.Value = Convert.ToDecimal(row.Cells["Harga"].Value);
            stok.Value = Convert.ToInt32(row.Cells["Stock"].Value);

            btn_save.Text = "Update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_menu.CurrentRow == null) return;

            int id = (int)dg_menu.CurrentRow.Cells["MenuId"].Value;

            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus menu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var menu = _Context.Menus.Find(id);
                if (menu != null)
                {
                    _Context.Menus.Remove(menu);
                    _Context.SaveChanges();
                    ClearForm();
                    loadmeja();
                    MessageBox.Show("Menu berhasil dihapus!");
                }
            }
        }
    }
}
