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
    public partial class ManajementMeja : UserControl
    {
        private DataConnection _Context;
        private User _CurrentUser;
        private int _selectedMejaId = 0;

        public ManajementMeja(User user)
        {
            InitializeComponent();
            _Context = new DataConnection();
            _CurrentUser = user;

            status.Items.Clear();
            status.Items.Add("Kosong");
            status.Items.Add("Dipesan");
            status.Items.Add("Terisi");

            LoadMeja();
        }

        private void LoadMeja()
        {
            var MejaList = _Context.Mejas
                .Select(m => new
                {
                    m.MejaId,
                    m.NoMeja,
                    m.Kapasitas,
                    m.Status
                })
                .ToList();

            dg_meja.DataSource = MejaList;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (status.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih status meja terlebih dahulu!");
                return;
            }

            int noMejaInput = (int)no_meja.Value;
            bool isDuplicate = _Context.Mejas.Any(m => m.NoMeja == noMejaInput && m.MejaId != _selectedMejaId);

            if (isDuplicate)
            {
                MessageBox.Show("Nomor meja ini sudah ada, gunakan nomor lain!");
                return;
            }

            if (_selectedMejaId == 0)
            {
                Meja newMeja = new Meja
                {
                    NoMeja = noMejaInput,
                    Kapasitas = (int)kapasitas.Value,
                    Status = status.SelectedItem.ToString()
                };
                _Context.Mejas.Add(newMeja);
            }
            else
            {
                var meja = _Context.Mejas.Find(_selectedMejaId);
                if (meja != null)
                {
                    meja.NoMeja = noMejaInput;
                    meja.Kapasitas = (int)kapasitas.Value;
                    meja.Status = status.SelectedItem.ToString();
                }
            }

            _Context.SaveChanges();
            ClearForm();
            LoadMeja();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dg_meja.CurrentRow != null)
            {
                _selectedMejaId = Convert.ToInt32(dg_meja.CurrentRow.Cells["MejaId"].Value);
                no_meja.Value = Convert.ToInt32(dg_meja.CurrentRow.Cells["NoMeja"].Value);
                kapasitas.Value = Convert.ToInt32(dg_meja.CurrentRow.Cells["Kapasitas"].Value);
                status.SelectedItem = dg_meja.CurrentRow.Cells["Status"].Value.ToString();
                btn_save.Text = "Update";
            }
        }

        private void ClearForm()
        {
            _selectedMejaId = 0;
            no_meja.Value = 1;
            kapasitas.Value = 1;
            status.SelectedIndex = -1;
            btn_save.Text = "Save";
        }

        private void dg_meja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedMejaId = Convert.ToInt32(dg_meja.Rows[e.RowIndex].Cells["MejaId"].Value);
            }
        }

        private void ManajementMeja_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dg_meja.CurrentRow == null) return;

            int id = (int)dg_meja.CurrentRow.Cells["MejaId"].Value;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus meja ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var meja = _Context.Mejas.Find(id);
                if (meja != null)
                {
                    _Context.Mejas.Remove(meja);
                    _Context.SaveChanges();
                    ClearForm();
                    LoadMeja();
                }
            }
        }
    }
}