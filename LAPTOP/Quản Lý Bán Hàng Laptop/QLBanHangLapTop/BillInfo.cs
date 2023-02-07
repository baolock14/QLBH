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
    public partial class BillInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");
        public BillInfo()
        {
            InitializeComponent();
        }

        private void BillInfo_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("USP_SelectAllCTHD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            conn.Close();
            dtgvBillInfo.DataSource = table;

            txbMaHD.DataBindings.Clear();
            txbMaHD.DataBindings.Add("Text", dtgvBillInfo.DataSource, "MaHD", true, DataSourceUpdateMode.Never);
            txbMaSP.DataBindings.Clear();
            txbMaSP.DataBindings.Add("Text", dtgvBillInfo.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            txbDonGia.DataBindings.Clear();
            txbDonGia.DataBindings.Add("Text", dtgvBillInfo.DataSource, "DonGiaBan", true, DataSourceUpdateMode.Never);
            txbThanhTien.DataBindings.Clear();
            txbThanhTien.DataBindings.Add("Text", dtgvBillInfo.DataSource, "ThanhTien", true, DataSourceUpdateMode.Never);
            nmSoLuong.DataBindings.Clear();
            nmSoLuong.DataBindings.Add("Text", dtgvBillInfo.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            nmGiamGia.DataBindings.Clear();
            nmGiamGia.DataBindings.Add("Text", dtgvBillInfo.DataSource, "GiamGia", true, DataSourceUpdateMode.Never);

            txbMaSPnew.Text = "";
            txbDonGia.Enabled = false;
            txbThanhTien.Enabled = false;
            dis_enb(false);
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyBillInfo.Enabled = e;
            btnLuuBillInfo.Enabled = e;

            btnSuaBillInfo.Enabled = !e;
            btnThemBillInfo.Enabled = !e;
            btnXoaBillInfo.Enabled = !e;
        }

        private void btnThemBillInfo_Click(object sender, EventArgs e)
        {
            flag = 0;
            txbMaHD.Text = "HD";
            txbMaSP.Text = "";
            txbDonGia.Text = "";
            txbThanhTien.Text = "";
            nmGiamGia.Text = "0";
            nmSoLuong.Text = "1";

            txbMaSPnew.Enabled = false;
            dis_enb(true);
        }

        private void btnXoaBillInfo_Click(object sender, EventArgs e)
        {
            string name = txbMaHD.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa hóa đơn {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand("USP_DeleteCTHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txbMaHD.Text;
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txbMaSP.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BillInfo_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaBillInfo_Click(object sender, EventArgs e)
        {
            flag = 1;

            txbMaSPnew.DataBindings.Clear();
            txbMaSPnew.DataBindings.Add("Text", dtgvBillInfo.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            txbMaHD.Enabled = false;
            txbMaSP.Enabled = false;
            txbMaSPnew.Enabled = true;

            dis_enb(true);
        }

        private void btnHuyBillInfo_Click(object sender, EventArgs e)
        {
            BillInfo_Load(sender, e);
            dis_enb(false);
        }

        private void btnLuuBillInfo_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                //Thêm
                if (txbMaHD.Text != "" && txbMaSP.Text != "" && nmSoLuong.Text != "") //&& nmGiamGia.Text != "" )
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_ThemCTHD",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txbMaHD.Text;
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txbMaSP.Text;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = Convert.ToInt32(nmSoLuong.Text);
                    cmd.Parameters.Add("@GiamGia", SqlDbType.Int).Value = Convert.ToInt32(nmGiamGia.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm hóa đơn mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BillInfo_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Sửa
                if (txbMaHD.Text != "" && txbMaSPnew.Text != "" && nmGiamGia.Text != "" && nmSoLuong.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_UpdateCTHD",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = txbMaHD.Text;
                    cmd.Parameters.Add("@MaSP", SqlDbType.VarChar).Value = txbMaSPnew.Text;
                    cmd.Parameters.Add("@MaSPCrr", SqlDbType.VarChar).Value = txbMaSP.Text;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = nmSoLuong.Value;
                    cmd.Parameters.Add("@GiamGia", SqlDbType.Int).Value = Convert.ToInt32(nmGiamGia.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BillInfo_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbTieuChi.Text != "" && txbTimKiem.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_TimKiemCTHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuChi.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txbTimKiem.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    conn.Close();
                    dtgvBillInfo.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ dữ liệu tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nmGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
