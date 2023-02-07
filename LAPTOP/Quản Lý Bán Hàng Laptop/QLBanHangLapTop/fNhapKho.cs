using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangLapTop
{
    public partial class fNhapKho : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");

        public fNhapKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fQLNhapKho f = new fQLNhapKho();
            f.ShowDialog();
            fNhapKho_Load(sender, e);
            this.Show();
        }

        public void fNhapKho_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("select * from LoaiSP", conn);
            var table = new DataTable();
            dap.Fill(table);
            cbLoaiSP.DisplayMember = "tenLoai";
            cbLoaiSP.ValueMember = "maLoai";
            cbLoaiSP.DataSource = table;

            txbMaLoaiSP.DataBindings.Clear();
            txbMaLoaiSP.DataBindings.Add("Text", cbLoaiSP.DataSource, "maLoai", true, DataSourceUpdateMode.Never);

            txbMaSP.Enabled = false;
            nmSPtrongKho.Enabled = false;
            txbTenSP.Enabled = false;
            txbMaLoaiSP.Enabled = false;
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbLoaiSP.SelectedValue);

                conn.Open();
                var cmd = new SqlCommand("SelectSPbyMaLoai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int).Value = id;
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();
                dtgvSanPham.DataSource = table;

                txbTenSP.DataBindings.Clear();
                txbTenSP.DataBindings.Add("Text", dtgvSanPham.DataSource, "tenSP", true, DataSourceUpdateMode.Never);
                txbMaSP.DataBindings.Clear();
                txbMaSP.DataBindings.Add("Text", dtgvSanPham.DataSource, "maSP", true, DataSourceUpdateMode.Never);
                nmSPtrongKho.DataBindings.Clear();
                nmSPtrongKho.DataBindings.Add("Text", dtgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);

                var dapPNK = new SqlDataAdapter("select nk.*, TenSP, SoLuongNhap * DonGiaNhap as thanhTien from PhieuNK as nk join SanPham on SanPham.MaSP = nk.MaSP", conn);
                var tablePNK = new DataTable();
                dapPNK.Fill(tablePNK);
                dtgvPhieuNK.DataSource = tablePNK;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            
            if (nmSoLuongNhap.Value > 0 && dtNgayNhap.Text != "" && txbDonGiaNhap.Text != "" && nmSoLuongNhap.Text != "")
            {
                conn.Open();
                var cmd = new SqlCommand("USP_ThemPNK", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txbMaSP.Text;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = dtNgayNhap.Text;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = Convert.ToInt32(txbDonGiaNhap.Text);
                cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = nmSoLuongNhap.Value;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(string.Format("Nhập kho thành công {0} {1}", nmSoLuongNhap.Value, txbTenSP.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Vui lòng nhập đủ thông tin"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fNhapKho_Load(sender, e);

        }

        private void txbDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nmSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
