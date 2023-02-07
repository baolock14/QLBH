
namespace QLBanHangLapTop
{
    partial class fChiNhanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvChiNhanh = new System.Windows.Forms.DataGridView();
            this.MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTieuChi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTimCN = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaCN = new System.Windows.Forms.Button();
            this.btnHuyCN = new System.Windows.Forms.Button();
            this.btnXoaCN = new System.Windows.Forms.Button();
            this.btnThemCN = new System.Windows.Forms.Button();
            this.btnLuuCN = new System.Windows.Forms.Button();
            this.txbMaCN = new System.Windows.Forms.TextBox();
            this.txbTenCN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiNhanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChiNhanh
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dtgvChiNhanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiNhanh.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCN,
            this.TenCN,
            this.DiaChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiNhanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiNhanh.GridColor = System.Drawing.Color.Lavender;
            this.dtgvChiNhanh.Location = new System.Drawing.Point(22, 168);
            this.dtgvChiNhanh.Name = "dtgvChiNhanh";
            this.dtgvChiNhanh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvChiNhanh.Size = new System.Drawing.Size(942, 345);
            this.dtgvChiNhanh.TabIndex = 27;
            // 
            // MaCN
            // 
            this.MaCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.HeaderText = "Mã chi nhánh";
            this.MaCN.Name = "MaCN";
            this.MaCN.Width = 139;
            // 
            // TenCN
            // 
            this.TenCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenCN.DataPropertyName = "TenCN";
            this.TenCN.FillWeight = 200F;
            this.TenCN.HeaderText = "Tên chi nhánh";
            this.TenCN.Name = "TenCN";
            this.TenCN.Width = 300;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTieuChi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbTimCN);
            this.panel1.Controls.Add(this.txbDiaChi);
            this.panel1.Controls.Add(this.btnTimSP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbMaCN);
            this.panel1.Controls.Add(this.txbTenCN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(22, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 121);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Tìm theo";
            // 
            // cbTieuChi
            // 
            this.cbTieuChi.BackColor = System.Drawing.Color.White;
            this.cbTieuChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuChi.FormattingEnabled = true;
            this.cbTieuChi.Items.AddRange(new object[] {
            "Tên chi nhánh",
            "Mã chi nhánh"});
            this.cbTieuChi.Location = new System.Drawing.Point(451, 32);
            this.cbTieuChi.Name = "cbTieuChi";
            this.cbTieuChi.Size = new System.Drawing.Size(121, 23);
            this.cbTieuChi.TabIndex = 90;
            this.cbTieuChi.Text = "Tên chi nhánh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(14, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Địa chỉ";
            // 
            // tbTimCN
            // 
            this.tbTimCN.BackColor = System.Drawing.Color.White;
            this.tbTimCN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbTimCN.Location = new System.Drawing.Point(578, 32);
            this.tbTimCN.Name = "tbTimCN";
            this.tbTimCN.Size = new System.Drawing.Size(250, 23);
            this.tbTimCN.TabIndex = 89;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BackColor = System.Drawing.Color.White;
            this.txbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbDiaChi.Location = new System.Drawing.Point(18, 84);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(377, 23);
            this.txbDiaChi.TabIndex = 32;
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.ForeColor = System.Drawing.Color.White;
            this.btnTimSP.Location = new System.Drawing.Point(834, 27);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(90, 30);
            this.btnTimSP.TabIndex = 88;
            this.btnTimSP.Text = "Tìm kiếm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaCN);
            this.panel2.Controls.Add(this.btnHuyCN);
            this.panel2.Controls.Add(this.btnXoaCN);
            this.panel2.Controls.Add(this.btnThemCN);
            this.panel2.Controls.Add(this.btnLuuCN);
            this.panel2.Location = new System.Drawing.Point(448, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 46);
            this.panel2.TabIndex = 74;
            // 
            // btnSuaCN
            // 
            this.btnSuaCN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaCN.FlatAppearance.BorderSize = 0;
            this.btnSuaCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCN.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaCN.ForeColor = System.Drawing.Color.White;
            this.btnSuaCN.Location = new System.Drawing.Point(195, 3);
            this.btnSuaCN.Name = "btnSuaCN";
            this.btnSuaCN.Size = new System.Drawing.Size(90, 40);
            this.btnSuaCN.TabIndex = 59;
            this.btnSuaCN.Text = "Sửa";
            this.btnSuaCN.UseVisualStyleBackColor = false;
            this.btnSuaCN.Click += new System.EventHandler(this.btnSuaCN_Click);
            // 
            // btnHuyCN
            // 
            this.btnHuyCN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHuyCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyCN.FlatAppearance.BorderSize = 0;
            this.btnHuyCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyCN.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuyCN.ForeColor = System.Drawing.Color.White;
            this.btnHuyCN.Location = new System.Drawing.Point(387, 3);
            this.btnHuyCN.Name = "btnHuyCN";
            this.btnHuyCN.Size = new System.Drawing.Size(90, 40);
            this.btnHuyCN.TabIndex = 55;
            this.btnHuyCN.Text = "Hủy";
            this.btnHuyCN.UseVisualStyleBackColor = false;
            this.btnHuyCN.Click += new System.EventHandler(this.btnHuyCN_Click);
            // 
            // btnXoaCN
            // 
            this.btnXoaCN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCN.FlatAppearance.BorderSize = 0;
            this.btnXoaCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCN.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaCN.ForeColor = System.Drawing.Color.White;
            this.btnXoaCN.Location = new System.Drawing.Point(99, 3);
            this.btnXoaCN.Name = "btnXoaCN";
            this.btnXoaCN.Size = new System.Drawing.Size(90, 40);
            this.btnXoaCN.TabIndex = 58;
            this.btnXoaCN.Text = "Xóa";
            this.btnXoaCN.UseVisualStyleBackColor = false;
            this.btnXoaCN.Click += new System.EventHandler(this.btnXoaCN_Click);
            // 
            // btnThemCN
            // 
            this.btnThemCN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCN.FlatAppearance.BorderSize = 0;
            this.btnThemCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCN.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCN.ForeColor = System.Drawing.Color.White;
            this.btnThemCN.Location = new System.Drawing.Point(3, 3);
            this.btnThemCN.Name = "btnThemCN";
            this.btnThemCN.Size = new System.Drawing.Size(90, 40);
            this.btnThemCN.TabIndex = 56;
            this.btnThemCN.Text = "Thêm";
            this.btnThemCN.UseVisualStyleBackColor = false;
            this.btnThemCN.Click += new System.EventHandler(this.btnThemCN_Click);
            // 
            // btnLuuCN
            // 
            this.btnLuuCN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLuuCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCN.FlatAppearance.BorderSize = 0;
            this.btnLuuCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuCN.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuCN.ForeColor = System.Drawing.Color.White;
            this.btnLuuCN.Location = new System.Drawing.Point(291, 3);
            this.btnLuuCN.Name = "btnLuuCN";
            this.btnLuuCN.Size = new System.Drawing.Size(90, 40);
            this.btnLuuCN.TabIndex = 57;
            this.btnLuuCN.Text = "Lưu";
            this.btnLuuCN.UseVisualStyleBackColor = false;
            this.btnLuuCN.Click += new System.EventHandler(this.btnLuuCN_Click);
            // 
            // txbMaCN
            // 
            this.txbMaCN.BackColor = System.Drawing.Color.White;
            this.txbMaCN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbMaCN.Location = new System.Drawing.Point(18, 32);
            this.txbMaCN.Name = "txbMaCN";
            this.txbMaCN.Size = new System.Drawing.Size(99, 23);
            this.txbMaCN.TabIndex = 43;
            // 
            // txbTenCN
            // 
            this.txbTenCN.BackColor = System.Drawing.Color.White;
            this.txbTenCN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTenCN.Location = new System.Drawing.Point(142, 32);
            this.txbTenCN.Name = "txbTenCN";
            this.txbTenCN.Size = new System.Drawing.Size(253, 23);
            this.txbTenCN.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã chi nhánh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(138, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Tên chi nhánh";
            // 
            // fChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvChiNhanh);
            this.Name = "fChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi nhánh";
            this.Load += new System.EventHandler(this.fChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiNhanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiNhanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTieuChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTimCN;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaCN;
        private System.Windows.Forms.Button btnHuyCN;
        private System.Windows.Forms.Button btnXoaCN;
        private System.Windows.Forms.Button btnThemCN;
        private System.Windows.Forms.Button btnLuuCN;
        private System.Windows.Forms.TextBox txbMaCN;
        private System.Windows.Forms.TextBox txbTenCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}