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
    public partial class fCustomer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=BAOLOC;Initial Catalog=LapTopPhin;Integrated Security=True");
        public fCustomer()
        {
            InitializeComponent();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("USP_SelectAllKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            conn.Close();
            dtgvKhachHang.DataSource = table;

            txbMaKH.DataBindings.Clear();
            txbMaKH.DataBindings.Add("Text", dtgvKhachHang.DataSource, "maKH", true, DataSourceUpdateMode.Never);
            txbTenKH.DataBindings.Clear();
            txbTenKH.DataBindings.Add("Text", dtgvKhachHang.DataSource, "tenKH", true, DataSourceUpdateMode.Never);
            txbSDTMaKH.DataBindings.Clear();
            txbSDTMaKH.DataBindings.Add("Text", dtgvKhachHang.DataSource, "dienThoai", true, DataSourceUpdateMode.Never);
            txbDiaChi.DataBindings.Clear();
            txbDiaChi.DataBindings.Add("Text", dtgvKhachHang.DataSource, "diaChi", true, DataSourceUpdateMode.Never);

            txbMaKH.Enabled = false;
            txbTenKH.Enabled = false;
            txbSDTMaKH.Enabled = false;
            txbDiaChi.Enabled = false;


            dis_enb(false);
        }
        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyKH.Enabled = e;
            btnLuuKH.Enabled = e;

            btnThemKH.Enabled = !e;
            btnXoaKH.Enabled = !e;
            btnSuaKH.Enabled = !e;
        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            fCustomer_Load(sender, e);
            dis_enb(false);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string name = txbTenKH.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa tài khoản {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand("USP_DeleteKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKH", SqlDbType.NVarChar).Value = txbMaKH.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fCustomer_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txbMaKH.Enabled = false;
            txbTenKH.Enabled = true;
            txbSDTMaKH.Enabled = true;
            txbDiaChi.Enabled = true;
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                // Thêm
                if (txbTenKH.Text != "" && txbSDTMaKH.Text != "" && txbDiaChi.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_ThemKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = txbTenKH.Text;
                    cmd.Parameters.Add("@dienThoai", SqlDbType.Char).Value = txbSDTMaKH.Text;
                    cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm khách hàng mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fCustomer_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Sửa
                if (txbTenKH.Text != "" && txbSDTMaKH.Text != "" && txbDiaChi.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_UpdateKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maKH", SqlDbType.VarChar).Value = txbMaKH.Text;
                    cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = txbTenKH.Text;
                    cmd.Parameters.Add("@dienThoai", SqlDbType.Char).Value = txbSDTMaKH.Text;
                    cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fCustomer_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            flag = 0;
           
            txbMaKH.Text = "";
            txbTenKH.Text = "";
            txbSDTMaKH.Text = ""; 
            txbDiaChi.Text = ""; 

            txbMaKH.Enabled = false;
            txbTenKH.Enabled = true;
            txbSDTMaKH.Enabled = true;
            txbDiaChi.Enabled = true;
            dis_enb(true);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (cbTieuchiKH.Text != "" && txbTimKH.Text != "")
            {
                conn.Open();
                var cmd = new SqlCommand("USP_TimKiemKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuchiKH.Text;
                cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = txbTimKH.Text;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();
                dtgvKhachHang.DataSource = table;
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txbSDTMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbTimKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
