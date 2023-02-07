using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLBanHangLapTop
{
    public partial class fStaff : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");

        public fStaff()
        {
            InitializeComponent();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("USP_SelectAllNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();
                dtgvStaff.DataSource = table;

                txbMaNV.DataBindings.Clear();
                txbMaNV.DataBindings.Add("Text", dtgvStaff.DataSource, "maNV", true, DataSourceUpdateMode.Never);
                txbTenNV.DataBindings.Clear();
                txbTenNV.DataBindings.Add("Text", dtgvStaff.DataSource, "tenNV", true, DataSourceUpdateMode.Never);
                txbDiaChi.DataBindings.Clear();
                txbDiaChi.DataBindings.Add("Text", dtgvStaff.DataSource, "diaChi", true, DataSourceUpdateMode.Never);
                dtpkNgaySinh.DataBindings.Clear();
                dtpkNgaySinh.DataBindings.Add("Text", dtgvStaff.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never);
                cbGioiTinh.DataBindings.Clear();
                cbGioiTinh.DataBindings.Add("Text", dtgvStaff.DataSource, "gioiTinh", true, DataSourceUpdateMode.Never);
                txbSDT.DataBindings.Clear();
                txbSDT.DataBindings.Add("Text", dtgvStaff.DataSource, "dienThoai", true, DataSourceUpdateMode.Never);

                txbMaNV.Enabled = false;
                txbTenNV.Enabled = false;
                txbDiaChi.Enabled = false;
                dtpkNgaySinh.Enabled = false;
                txbSDT.Enabled = false;
                cbGioiTinh.Enabled = false;
                dis_enb(false);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyNV.Enabled = e;
            btnLuuNV.Enabled = e;

            btnThemNV.Enabled = !e;
            btnXoaNV.Enabled = !e;
            btnSuaNV.Enabled = !e;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string name = txbTenNV.Text;

            try
            {
                if (MessageBox.Show(string.Format("Bạn có muốn xóa tài khoản {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_DeleteNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNV", SqlDbType.VarChar).Value = txbMaNV.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fStaff_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            cbGioiTinh.Enabled = true;
            txbMaNV.Enabled = false;
            txbTenNV.Enabled = true;
            txbDiaChi.Enabled = true;
            dtpkNgaySinh.Enabled = true;
            txbSDT.Enabled = true;
            cbGioiTinh.Enabled = true;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                // Thêm

                try
                {
                    if (txbTenNV.Text != "" && txbDiaChi.Text != "" && dtpkNgaySinh.Text != "" && txbSDT.Text != "" && cbGioiTinh.Text != "")
                    {
                        conn.Open();
                        var cmd = new SqlCommand("USP_ThemNV", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = txbTenNV.Text;
                        cmd.Parameters.Add("@dienThoai", SqlDbType.Char).Value = txbSDT.Text;
                        cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                        cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = dtpkNgaySinh.Text;
                        cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cbGioiTinh.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Thêm nhân viên mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fStaff_Load(sender, e);
            }
            else
            {
                    // Sửa
                try
                {
                    if (txbTenNV.Text != "" && txbDiaChi.Text != "" && dtpkNgaySinh.Text != "" && txbSDT.Text != "" && cbGioiTinh.Text != "")
                    {
                        conn.Open();
                        var cmd = new SqlCommand("USP_UpdateNV", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@maNV", SqlDbType.VarChar).Value = txbMaNV.Text;
                        cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = txbTenNV.Text;
                        cmd.Parameters.Add("@dienThoai", SqlDbType.VarChar).Value = txbSDT.Text;
                        cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = dtpkNgaySinh.Text;
                        cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                        cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cbGioiTinh.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fStaff_Load(sender, e);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            flag = 0;
           
            txbMaNV.Text = "";
            txbTenNV.Text = "";
            txbSDT.Text = ""; 
            txbDiaChi.Text = ""; 
            cbGioiTinh.Text = "";

            txbMaNV.Enabled = false;
            txbTenNV.Enabled = true;
            dtpkNgaySinh.Enabled = true;
            txbSDT.Enabled = true;
            txbDiaChi.Enabled = true;
            cbGioiTinh.Enabled = true;
            dis_enb(true);
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            fStaff_Load(sender, e);
            dis_enb(false);
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTieuChi.Text != "" && tbTimNV.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_TimKiemNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuChi.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = tbTimNV.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    conn.Close();
                    dtgvStaff.DataSource = table;
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
