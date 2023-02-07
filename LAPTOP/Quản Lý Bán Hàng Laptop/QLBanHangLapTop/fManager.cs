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
    public partial class fManager : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Laptop;Integrated Security=True");
        public fManager()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProduct f = new fProduct();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }



        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có muốn đăng xuất "), "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChiNhanh f = new fChiNhanh();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapKho f = new fNhapKho();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }



        private void hóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }



        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillInfo f = new BillInfo();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            fNhapKho f = new fNhapKho();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            BillInfo f = new BillInfo();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            fChiNhanh f = new fChiNhanh();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            fProduct f = new fProduct();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            fManager_Load(sender, e);
            this.Show();
        }

        private void fManager_Load_1(object sender, EventArgs e)
        {

        }
    }
}
