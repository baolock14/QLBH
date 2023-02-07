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
    public partial class fQLNhapKho : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");
        public fQLNhapKho()
        {
            InitializeComponent();
        }

        private void fQLNhapKho_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("USP_SelectPhieuNK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            conn.Close();
            dtgvPhieuNK.DataSource = table;

            txbMaPhieu.DataBindings.Clear();
            txbMaPhieu.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never);
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            dtNgayNhapPNK.DataBindings.Clear();
            dtNgayNhapPNK.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "NgayNhap", true, DataSourceUpdateMode.Never);
            nmSoLuongSPPNK.DataBindings.Clear();
            nmSoLuongSPPNK.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "SoLuongNhap", true, DataSourceUpdateMode.Never);
            txbTenSPPNK.DataBindings.Clear();
            txbTenSPPNK.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "tenSP", true, DataSourceUpdateMode.Never);
            txbDonGiaNhap.DataBindings.Clear();
            txbDonGiaNhap.DataBindings.Add("Text", dtgvPhieuNK.DataSource, "DonGiaNhap", true, DataSourceUpdateMode.Never);

            txtMaSP.Enabled = false;
            txbMaPhieu.Enabled = false;
            txbTenSPPNK.Enabled = false;
            txbDonGiaNhap.Enabled = false;
            dtNgayNhapPNK.Enabled = false;
            nmSoLuongSPPNK.Enabled = false;
            dis_enb(false);

        }
        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuySP.Enabled = e;
            btnLuuSP.Enabled = e;

            btnXoaPhieu.Enabled = !e;
            btnSuaPhieu.Enabled = !e;
        }
        private void txbDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            flag = 1;
            txbDonGiaNhap.Enabled = true;
            nmSoLuongSPPNK.Enabled = true;
            dtNgayNhapPNK.Enabled = true;

            dis_enb(true);
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string name = txbMaPhieu.Text;
            DialogResult lenh = MessageBox.Show("Bạn có chắc chắn xóa phiếu nhập kho này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lenh == DialogResult.Yes)
            {
                if (MessageBox.Show(string.Format("Bạn có muốn xóa phiếu có mã {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_DeletePNK", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar).Value = txbMaPhieu.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa phiếu nhập kho thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQLNhapKho_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập kho thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            // Sửa
            if (dtNgayNhapPNK.Text != "" && nmSoLuongSPPNK.Text != "" && txbDonGiaNhap.Text != "" )
            {
                conn.Open();
                var cmd = new SqlCommand("USP_UpdatePNK", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar).Value = txbMaPhieu.Text;
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txtMaSP.Text;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = dtNgayNhapPNK.Text;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = Convert.ToInt32(txbDonGiaNhap.Text);
                cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = Convert.ToInt32(nmSoLuongSPPNK.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa thông tin phiếu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fQLNhapKho_Load(sender, e);
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            fQLNhapKho_Load(sender, e);
            dis_enb(false);
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTieuChi.Text != "" && tbTimPNK.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_TimKiemPNK", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuChi.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = tbTimPNK.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    conn.Close();
                    dtgvPhieuNK.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm phiếu nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
