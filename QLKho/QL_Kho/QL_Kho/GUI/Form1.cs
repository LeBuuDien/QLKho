using QL_Kho.BLL;
using QL_Kho.DAL;
using System;
using System.Windows.Forms;

namespace QL_Kho
{
    public partial class Form1 : Form
    {
        DONHANG DONHANG;
        QLKhoDataContext ql = new QLKhoDataContext();
        public Form1()
        {
            InitializeComponent();
            txtMaVD.Enabled = txtTenNN.Enabled = txtDCN.Enabled = txtDCG.Enabled
                = txtCR.Enabled = txtCD.Enabled = txtCC.Enabled = txtTL.Enabled
                = btnSave.Enabled = btnClean.Enabled = btnSaveEdit.Enabled = btnDel.Enabled = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtMaVD.Enabled = txtTenNN.Enabled = txtDCN.Enabled = txtDCG.Enabled
                = txtCR.Enabled = txtCD.Enabled = txtCC.Enabled = txtTL.Enabled
                = btnSave.Enabled = btnClean.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DONHANG = new DONHANG();
            dataGridView1.DataSource = DONHANG.loadDH();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.MaVanDon = txtMaVD.Text;
            dh.TenNguoiGui = txtTenNN.Text;
            dh.DiaChiGui = txtDCG.Text;
            dh.DiaChiNhan = txtDCN.Text;
            dh.TrongLuong = float.Parse(txtTL.Text);
            dh.ChieuDai = int.Parse(txtCD.Text);
            dh.ChieuRong = int.Parse(txtCR.Text);
            dh.ChieuCao = int.Parse(txtCC.Text);

            if (DONHANG.addDH(dh))
            {
                MessageBox.Show("succesful");
            }
            else
                MessageBox.Show("Try again");

        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            DONHANG = new DONHANG();
            dataGridView1.DataSource = DONHANG.loadDH();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            txtTenNN.Enabled = txtDCN.Enabled = txtDCG.Enabled = txtCR.Enabled = txtCD.Enabled = txtCC.Enabled = txtTL.Enabled
    = btnSave.Enabled = btnClean.Enabled = btnSaveEdit.Enabled = false;
            txtMaVD.Enabled = btnDel.Enabled = true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.MaVanDon = txtMaVD.Text;
            dh.TenNguoiGui = txtTenNN.Text;
            dh.DiaChiGui = txtDCG.Text;
            dh.DiaChiNhan = txtDCN.Text;
            dh.TrongLuong = float.Parse(txtTL.Text);
            dh.ChieuDai = int.Parse(txtCD.Text);
            dh.ChieuRong = int.Parse(txtCR.Text);
            dh.ChieuCao = int.Parse(txtCC.Text);

            if (DONHANG.updateDH(dh))
            {
                MessageBox.Show("succesful");
            }
            else
                MessageBox.Show("Try again");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaVD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDCG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDCN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCD.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCC.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DONHANG.delC(txtMaVD.Text))
            {
                MessageBox.Show("succesful");
            }
            else
                MessageBox.Show("Try again");

        }

        private void txtEDIT_Click(object sender, EventArgs e)
        {
            txtMaVD.Enabled = txtTenNN.Enabled = txtDCN.Enabled = txtDCG.Enabled
                = txtCR.Enabled = txtCD.Enabled = txtCC.Enabled = txtTL.Enabled
               = btnClean.Enabled = btnSaveEdit.Enabled = true;
            btnSave.Enabled = btnDel.Enabled = false;
        }

        private void txtTL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            txtMaVD.Text = txtTenNN.Text = txtDCG.Text = txtDCN.Text = txtTL.Text = txtCD.Text = txtCR.Text = txtCC.Text = string.Empty;
        }
    }
}
