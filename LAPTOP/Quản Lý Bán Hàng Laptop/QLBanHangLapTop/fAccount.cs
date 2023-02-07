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
    public partial class fAccount : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");
        public fAccount()
        {
            InitializeComponent();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("selectAllTK", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            conn.Close();
            dtgvTaiKhoan.DataSource = table;

            txtUserName.DataBindings.Clear();
            txtUserName.DataBindings.Add("Text", dtgvTaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txbPassWord.DataBindings.Clear();
            txbPassWord.DataBindings.Add("Text", dtgvTaiKhoan.DataSource, "Password", true, DataSourceUpdateMode.Never);
            txbLoaiTK.DataBindings.Clear();
            txbLoaiTK.DataBindings.Add("Text", dtgvTaiKhoan.DataSource, "typeAcc", true, DataSourceUpdateMode.Never);
            dis_enb(false);
        }

        int flag = 0;
        void dis_enb(bool e)
        {
            btnHuyTK.Enabled = e;
            btnLuuTK.Enabled = e;

            btnThemTK.Enabled = !e;
            btnXoaTK.Enabled = !e;
            btnSuaTK.Enabled = !e;
        }

        private void btnThemTK_Click_1(object sender, EventArgs e)
        {
            flag = 0;
            txtUserName.Text = "";
            txbPassWord.Text = "";
            txbLoaiTK.Text = "";
            txtUserName.Enabled = true;      
            dis_enb(true);
        }

        private void btnXoaTK_Click_1(object sender, EventArgs e)
        {
            string name = txtUserName.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa tài khoản {0} ", name), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand("USP_DeleteTAcc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fAccount_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaTK_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            dis_enb(true);
            txtUserName.Enabled = false;
        }

        private void btnLuuTK_Click_1(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                // Thêm
                if (txtUserName.Text != "" && txbPassWord.Text != "" && txbLoaiTK.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_ThemAcc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@passWord", SqlDbType.VarChar).Value = txbPassWord.Text;
                    cmd.Parameters.Add("@TypeAcc", SqlDbType.VarChar).Value = txbLoaiTK.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fAccount_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Sửa
                if (txbPassWord.Text != "" && txtUserName.Text != "")
                {
                    conn.Open();
                    var cmd = new SqlCommand("USP_UpdateAcc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@passWord", SqlDbType.VarChar).Value = txbPassWord.Text;
                    cmd.Parameters.Add("@TypeAcc", SqlDbType.VarChar).Value = txbLoaiTK.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fAccount_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuyTK_Click_1(object sender, EventArgs e)
        {
            fAccount_Load(sender, e);
            dis_enb(false);
        }
    }
}
