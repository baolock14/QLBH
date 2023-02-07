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
    public partial class Bill : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("SelectAllHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();
                dtgvBill.DataSource = table;

                txbMaHD.DataBindings.Clear();
                txbMaHD.DataBindings.Add("Text", dtgvBill.DataSource, "MaHD", true, DataSourceUpdateMode.Never);
                txbMaKH.DataBindings.Clear();
                txbMaKH.DataBindings.Add("Text", dtgvBill.DataSource, "MaKH", true, DataSourceUpdateMode.Never);
                txbMaCN.DataBindings.Clear();
                txbMaCN.DataBindings.Add("Text", dtgvBill.DataSource, "MaCN", true, DataSourceUpdateMode.Never);
                txbMaNV.DataBindings.Clear();
                txbMaNV.DataBindings.Add("Text", dtgvBill.DataSource, "MaNV", true, DataSourceUpdateMode.Never);
                dtpkNgayBan.DataBindings.Clear();
                dtpkNgayBan.DataBindings.Add("Text", dtgvBill.DataSource, "NgayBan", true, DataSourceUpdateMode.Never);
                txbGiamGia.DataBindings.Clear();
                txbGiamGia.DataBindings.Add("Text", dtgvBill.DataSource, "TongGiamGia", true, DataSourceUpdateMode.Never);
                txbTinhTrang.DataBindings.Clear();
                txbTinhTrang.DataBindings.Add("Text", dtgvBill.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never);
                txbGhiChu.DataBindings.Clear();
                txbGhiChu.DataBindings.Add("Text", dtgvBill.DataSource, "GhiChu", true, DataSourceUpdateMode.Never);
                txbTongTien.DataBindings.Clear();
                txbTongTien.DataBindings.Add("Text", dtgvBill.DataSource, "TongTien", true, DataSourceUpdateMode.Never);
                txbTongTienPhaiTra.DataBindings.Clear();
                txbTongTienPhaiTra.DataBindings.Add("Text", dtgvBill.DataSource, "TongTienPhaiTra", true, DataSourceUpdateMode.Never);

                txbMaHD.Enabled = false;
                txbMaKH.Enabled = false;
                txbMaNV.Enabled = false;
                txbMaCN.Enabled = false;
                txbTongTien.Enabled = false;
                txbGiamGia.Enabled = false;
                txbGhiChu.Enabled = false;
                txbTinhTrang.Enabled = false;
                txbTongTienPhaiTra.Enabled = false;
                txbTongTien.Enabled = false;
                dtpkNgayBan.Enabled = false;
                dis_enb(false);

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            BillInfo f = new BillInfo();
            f.ShowDialog();
            Bill_Load(sender, e);
            this.Show();
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyHD.Enabled = e;
            btnLuuHD.Enabled = e;

            btnThemHD.Enabled = !e;
            btnXoaHD.Enabled = !e;
            btnSuaHD.Enabled = !e;
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string name = txbMaHD.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa hóa đơn {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand("USP_DeleteHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txbMaHD.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bill_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            flag = 0;
            txbMaHD.Text = "";
            txbMaKH.Text = "";
            txbMaCN.Text = "";
            txbMaNV.Text = "";
            txbGiamGia.Text = "0";
            txbTongTien.Text = "0";
            txbTongTienPhaiTra.Text = "0";
            txbGhiChu.Text = "";
            txbTinhTrang.Text = "";

            txbMaHD.Enabled = false;
            txbMaKH.Enabled = true;
            txbMaNV.Enabled = true;
            txbMaCN.Enabled = true;
            txbTongTien.Enabled = false;
            txbGiamGia.Enabled = false;
            txbGhiChu.Enabled = true;
            txbTinhTrang.Enabled = true;
            txbTongTienPhaiTra.Enabled = false;
            txbTongTien.Enabled = false;
            dtpkNgayBan.Enabled = true;
            dis_enb(true);
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                // Thêm
                if (txbMaCN.Text != "" && txbMaKH.Text != "" && txbMaNV.Text != "" && dtpkNgayBan.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_ThemHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txbMaNV.Text;
                    cmd.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = txbMaCN.Text;
                    cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = txbMaKH.Text;
                    cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = dtpkNgayBan.Text;
                    cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txbGhiChu.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txbTinhTrang.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm hóa đơn mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Bill_Load(sender, e);
            }
            else
            {
                // Sửa
                if (txbMaCN.Text != "" && txbMaKH.Text != "" && txbMaNV.Text != "" && dtpkNgayBan.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_UpdateHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = txbMaHD.Text;
                    cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = txbMaNV.Text;
                    cmd.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = txbMaCN.Text;
                    cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = txbMaKH.Text;
                    cmd.Parameters.Add("@NgayBan", SqlDbType.DateTime).Value = dtpkNgayBan.Text;
                    cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txbGhiChu.Text;
                    cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txbTinhTrang.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thông tin hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Bill_Load(sender, e);
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txbMaHD.Enabled = false;
            txbMaKH.Enabled = true;
            txbMaNV.Enabled = true;
            txbMaCN.Enabled = true;
            txbTongTien.Enabled = false;
            txbGiamGia.Enabled = false;
            txbGhiChu.Enabled = true;
            txbTinhTrang.Enabled = true;
            txbTongTienPhaiTra.Enabled = false;
            txbTongTien.Enabled = false;
            dtpkNgayBan.Enabled = true;
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            Bill_Load(sender, e);
            dis_enb(false);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTieuChi.Text != "" && txbTimKiem.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_TimKiemHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuChi.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txbTimKiem.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    conn.Close();
                    dtgvBill.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
