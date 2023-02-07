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
    public partial class fProduct : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");

        public fProduct()
        {
            InitializeComponent();
        }

        public void fProduct_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                var cmd = new SqlCommand("USP_SelectAllLoaiSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();

                cbLoaiSPham.DisplayMember = "tenLoai";
                cbLoaiSPham.ValueMember = "MaLoai";
                cbLoaiSPham.DataSource = table;
                txbMaLoaiSP.DataBindings.Clear();
                txbMaLoaiSP.DataBindings.Add("Text", cbLoaiSPham.DataSource, "MaLoai", true, DataSourceUpdateMode.Never);

                cbLoaiSPham.Enabled = true;
                txbMaSP.Enabled = false;
                txbTenSP.Enabled = false;
                cbHangSX.Enabled = false;
                txbDonGiaBan.Enabled = false;
                txbSoLuongSP.Enabled = false;
                txbMaLoaiSP.Enabled = false;
                nmBaoHanh.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dis_enb(false);
        }

        private void cbLoaiSPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbLoaiSPham.SelectedValue);
                var dap = new SqlDataAdapter("select * from SanPham where MaLoai = " + id + "", conn);
                var table = new DataTable();
                dap.Fill(table);
                dtgvSanPham.DataSource = table;

                txbTenSP.DataBindings.Clear();
                txbTenSP.DataBindings.Add("Text", dtgvSanPham.DataSource, "tenSP", true, DataSourceUpdateMode.Never);
                txbMaSP.DataBindings.Clear();
                txbMaSP.DataBindings.Add("Text", dtgvSanPham.DataSource, "maSP", true, DataSourceUpdateMode.Never);
                cbHangSX.DataBindings.Clear();
                cbHangSX.DataBindings.Add("Text", dtgvSanPham.DataSource, "hangSX", true, DataSourceUpdateMode.Never);
                txbSoLuongSP.DataBindings.Clear();
                txbSoLuongSP.DataBindings.Add("Text", dtgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
                txbDonGiaBan.DataBindings.Clear();
                txbDonGiaBan.DataBindings.Add("Text", dtgvSanPham.DataSource, "DonGiaBan", true, DataSourceUpdateMode.Never);
                nmBaoHanh.DataBindings.Clear();
                nmBaoHanh.DataBindings.Add("Text", dtgvSanPham.DataSource, "BaoHanh", true, DataSourceUpdateMode.Never);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuySP.Enabled = e;
            btnHuySP.Enabled = e;
            btnLuuSP.Enabled = e;
            btnLuuSP.Enabled = e;

            btnThemSP.Enabled = !e;
            btnXoaSP.Enabled = !e;
            btnSuaSP.Enabled = !e;
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            cbLoaiSPham.Enabled = true;

            fProduct_Load(sender, e);
            dis_enb(false);
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);

            cbLoaiSPham.Enabled = false;
            txbMaSP.Enabled = true;
            txbTenSP.Enabled = true;
            cbHangSX.Enabled = true;
            txbDonGiaBan.Enabled = true;
            txbSoLuongSP.Enabled = false;
            txbMaLoaiSP.Enabled = true;
            nmBaoHanh.Enabled = true;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string name = txbTenSP.Text;

            try
            {
                if (txbSoLuongSP.Value == 0 && MessageBox.Show(string.Format("Bạn có muốn xóa sản phẩm {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_DeleteSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = txbMaSP.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fProduct_Load(sender, e);

                    txbMaSP.Text = "";
                    cbHangSX.Text = "";
                    txbTenSP.Text = "";
                    txbDonGiaBan.Text = "";
                    txbSoLuongSP.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại !\nBạn chỉ được xóa khi bán hết sản phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                //Thêm
                try
                {
                    if (cbHangSX.Text != "" && txbTenSP.Text != "" && txbDonGiaBan.Text != "" && nmBaoHanh.Text != "")
                    {
                        conn.Open();
                        var cmd = new SqlCommand("USP_ThemSP", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@tenSP", SqlDbType.NVarChar).Value = txbTenSP.Text;
                        cmd.Parameters.Add("@hangSX", SqlDbType.NVarChar).Value = cbHangSX.Text;
                        cmd.Parameters.Add("@DonGiaBan", SqlDbType.Int).Value = Convert.ToInt32(txbDonGiaBan.Text);
                        cmd.Parameters.Add("@maLoai", SqlDbType.Int).Value = Convert.ToInt32(txbMaLoaiSP.Text);
                        cmd.Parameters.Add("@BaoHanh", SqlDbType.Int).Value = Convert.ToInt32(nmBaoHanh.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Sửa
                try
                {
                    if (cbHangSX.Text != "" && txbTenSP.Text != "" && txbDonGiaBan.Text != "" && nmBaoHanh.Text != "")
                    {
                        conn.Open();
                        var cmd = new SqlCommand("USP_UpdateSP", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = txbMaSP.Text;
                        cmd.Parameters.Add("@tenSP", SqlDbType.NVarChar).Value = txbTenSP.Text;
                        cmd.Parameters.Add("@hangSX", SqlDbType.NVarChar).Value = cbHangSX.Text;
                        cmd.Parameters.Add("@DonGiaBan", SqlDbType.Int).Value = Convert.ToInt32(txbDonGiaBan.Text);
                        cmd.Parameters.Add("@BaoHanh", SqlDbType.Int).Value = Convert.ToInt32(nmBaoHanh.Text);
                        cmd.Parameters.Add("@maLoai", SqlDbType.Int).Value = Convert.ToInt32(txbMaLoaiSP.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thông tin sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cbLoaiSPham.Enabled = false;
            fProduct_Load(sender, e);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            flag = 0;

            txbMaSP.Text = "";
            cbHangSX.Text = "";
            txbTenSP.Text = "";
            txbDonGiaBan.Text = "";
            txbSoLuongSP.Text = "";


            txbMaSP.Enabled = false;
            cbHangSX.Enabled = true;
            txbTenSP.Enabled = true;
            txbDonGiaBan.Enabled = true;
            txbSoLuongSP.Enabled = false;
            nmBaoHanh.Enabled = true;
            dis_enb(true);
        }


        private void label15_Click(object sender, EventArgs e)
        {

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

        private void btnNhapSP_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTieuchiSP.Text != "" && txbTextSP.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_TimKiemSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuchiSP.Text;
                    cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txbTextSP.Text;
                    cmd.ExecuteNonQuery();
                    var dap = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    dap.Fill(table);
                    conn.Close();
                    dtgvSanPham.DataSource = table;
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

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            fNhapKho f = new fNhapKho();
            this.Hide();
            f.ShowDialog();
            fProduct_Load(sender, e);
            this.Show();
        }
    }
}
