using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanHangLapTop
{
    public partial class fChiNhanh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");

        public fChiNhanh()
        {
            InitializeComponent();
        }

        private void fChiNhanh_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("USP_SelectAllChiNhanh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            conn.Close();
            dtgvChiNhanh.DataSource = table;

            txbMaCN.DataBindings.Clear();
            txbMaCN.DataBindings.Add("Text", dtgvChiNhanh.DataSource, "MaCN", true, DataSourceUpdateMode.Never);
            txbTenCN.DataBindings.Clear();
            txbTenCN.DataBindings.Add("Text", dtgvChiNhanh.DataSource, "TenCN", true, DataSourceUpdateMode.Never);
            txbDiaChi.DataBindings.Clear();
            txbDiaChi.DataBindings.Add("Text", dtgvChiNhanh.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
           
            txbMaCN.Enabled = false;
            txbTenCN.Enabled = false;
            txbDiaChi.Enabled = false;
            dis_enb(false);
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyCN.Enabled = e;
            btnLuuCN.Enabled = e;

            btnThemCN.Enabled = !e;
            btnXoaCN.Enabled = !e;
            btnSuaCN.Enabled = !e;
        }

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            flag = 0;

            txbMaCN.Text = "";
            txbTenCN.Text = "";
            txbDiaChi.Text = "";

            txbMaCN.Enabled = false;
            txbTenCN.Enabled = true;
            txbDiaChi.Enabled = true;
            dis_enb(true);
        }

        private void btnXoaCN_Click(object sender, EventArgs e)
        {
            string name = txbTenCN.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa chi nhánh {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand("USP_DeleteCNhanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCN", SqlDbType.VarChar).Value = txbMaCN.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa chi nhánh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fChiNhanh_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaCN_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txbMaCN.Enabled = false;
            txbTenCN.Enabled = true;
            txbDiaChi.Enabled = true;
        }

        private void btnLuuCN_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                // Thêm
                if (txbDiaChi.Text != "" && txbTenCN.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_ThemCN", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenCN", SqlDbType.NVarChar).Value = txbTenCN.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm chi nhánh mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin chi nhánh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fChiNhanh_Load(sender, e);
            }
            else
            {
                // Sửa
                if (txbDiaChi.Text != "" && txbTenCN.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_UpdateCN", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenCN", SqlDbType.NVarChar).Value = txbTenCN.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                    cmd.Parameters.Add("@MaCN", SqlDbType.VarChar).Value = txbMaCN.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thông tin chi nhánh thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin chi nhánh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fChiNhanh_Load(sender, e);
            }
        }

        private void btnHuyCN_Click(object sender, EventArgs e)
        {
            fChiNhanh_Load(sender, e);
            dis_enb(false);
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            if (cbTieuChi.Text != "" && tbTimCN.Text != "")
            {
                conn.Open();
                var cmd = new SqlCommand("USP_TimKiemCN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TieuChi", SqlDbType.NVarChar).Value = cbTieuChi.Text;
                cmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = tbTimCN.Text;
                cmd.ExecuteNonQuery();
                var dap = new SqlDataAdapter(cmd);
                var table = new DataTable();
                dap.Fill(table);
                conn.Close();
                dtgvChiNhanh.DataSource = table;
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
