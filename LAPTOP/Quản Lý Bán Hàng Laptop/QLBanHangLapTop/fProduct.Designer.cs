namespace QLBanHangLapTop
{
    partial class fProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nmBaoHanh = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTieuchiSP = new System.Windows.Forms.ComboBox();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.txbMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaSP = new System.Windows.Forms.TextBox();
            this.txbDonGiaBan = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnHuySP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.txbSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.txbTextSP = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiSPham = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbHangSX = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBaoHanh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSoLuongSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtgvSanPham);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 591);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(507, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 33;
            this.label8.Text = "Sản phẩm";
            // 
            // dtgvSanPham
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dtgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.tenSP,
            this.hangSX,
            this.soLuong,
            this.DonGiaBan,
            this.maLoai,
            this.BaoHanh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSanPham.GridColor = System.Drawing.Color.Lavender;
            this.dtgvSanPham.Location = new System.Drawing.Point(27, 256);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvSanPham.Size = new System.Drawing.Size(1103, 309);
            this.dtgvSanPham.TabIndex = 26;
            // 
            // maSP
            // 
            this.maSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.Name = "maSP";
            this.maSP.Width = 137;
            // 
            // tenSP
            // 
            this.tenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.FillWeight = 200F;
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.Name = "tenSP";
            // 
            // hangSX
            // 
            this.hangSX.DataPropertyName = "hangSX";
            this.hangSX.HeaderText = "Hãng sản xuất";
            this.hangSX.Name = "hangSX";
            this.hangSX.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Tổng số lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 150;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 130;
            // 
            // maLoai
            // 
            this.maLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maLoai.DataPropertyName = "maLoai";
            this.maLoai.HeaderText = "Mã loại";
            this.maLoai.Name = "maLoai";
            // 
            // BaoHanh
            // 
            this.BaoHanh.DataPropertyName = "BaoHanh";
            this.BaoHanh.HeaderText = "Bảo hành";
            this.BaoHanh.Name = "BaoHanh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.btnNhapKho);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nmBaoHanh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbTieuchiSP);
            this.panel2.Controls.Add(this.txbTenSP);
            this.panel2.Controls.Add(this.txbMaLoaiSP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbMaSP);
            this.panel2.Controls.Add(this.txbDonGiaBan);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txbSoLuongSP);
            this.panel2.Controls.Add(this.txbTextSP);
            this.panel2.Controls.Add(this.btnTimSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbLoaiSPham);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbHangSX);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(27, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 181);
            this.panel2.TabIndex = 1;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapKho.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNhapKho.Location = new System.Drawing.Point(607, 120);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(285, 50);
            this.btnNhapKho.TabIndex = 97;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(366, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tháng";
            // 
            // nmBaoHanh
            // 
            this.nmBaoHanh.BackColor = System.Drawing.Color.White;
            this.nmBaoHanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmBaoHanh.ForeColor = System.Drawing.Color.OrangeRed;
            this.nmBaoHanh.Location = new System.Drawing.Point(314, 131);
            this.nmBaoHanh.Name = "nmBaoHanh";
            this.nmBaoHanh.Size = new System.Drawing.Size(46, 23);
            this.nmBaoHanh.TabIndex = 95;
            this.nmBaoHanh.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(310, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Bảo hành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(608, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Tìm theo";
            // 
            // cbTieuchiSP
            // 
            this.cbTieuchiSP.BackColor = System.Drawing.Color.White;
            this.cbTieuchiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuchiSP.FormattingEnabled = true;
            this.cbTieuchiSP.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Mã sản phẩm",
            "Hãng sản xuất"});
            this.cbTieuchiSP.Location = new System.Drawing.Point(610, 33);
            this.cbTieuchiSP.Name = "cbTieuchiSP";
            this.cbTieuchiSP.Size = new System.Drawing.Size(129, 23);
            this.cbTieuchiSP.TabIndex = 92;
            this.cbTieuchiSP.Text = "Mã sản phẩm";
            // 
            // txbTenSP
            // 
            this.txbTenSP.BackColor = System.Drawing.Color.White;
            this.txbTenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTenSP.Location = new System.Drawing.Point(196, 33);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(207, 23);
            this.txbTenSP.TabIndex = 86;
            // 
            // txbMaLoaiSP
            // 
            this.txbMaLoaiSP.BackColor = System.Drawing.Color.White;
            this.txbMaLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbMaLoaiSP.Location = new System.Drawing.Point(18, 82);
            this.txbMaLoaiSP.Name = "txbMaLoaiSP";
            this.txbMaLoaiSP.Size = new System.Drawing.Size(56, 23);
            this.txbMaLoaiSP.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Mã loại";
            // 
            // txbMaSP
            // 
            this.txbMaSP.BackColor = System.Drawing.Color.White;
            this.txbMaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbMaSP.Location = new System.Drawing.Point(96, 82);
            this.txbMaSP.Name = "txbMaSP";
            this.txbMaSP.Size = new System.Drawing.Size(71, 23);
            this.txbMaSP.TabIndex = 81;
            // 
            // txbDonGiaBan
            // 
            this.txbDonGiaBan.BackColor = System.Drawing.Color.White;
            this.txbDonGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbDonGiaBan.Location = new System.Drawing.Point(314, 82);
            this.txbDonGiaBan.Name = "txbDonGiaBan";
            this.txbDonGiaBan.Size = new System.Drawing.Size(89, 23);
            this.txbDonGiaBan.TabIndex = 80;
            this.txbDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGiaBan_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSuaSP);
            this.panel3.Controls.Add(this.btnHuySP);
            this.panel3.Controls.Add(this.btnXoaSP);
            this.panel3.Controls.Add(this.btnThemSP);
            this.panel3.Controls.Add(this.btnLuuSP);
            this.panel3.Location = new System.Drawing.Point(607, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 48);
            this.panel3.TabIndex = 78;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSP.FlatAppearance.BorderSize = 0;
            this.btnSuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(99, 5);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(90, 40);
            this.btnSuaSP.TabIndex = 59;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnHuySP
            // 
            this.btnHuySP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHuySP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuySP.FlatAppearance.BorderSize = 0;
            this.btnHuySP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuySP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuySP.ForeColor = System.Drawing.Color.White;
            this.btnHuySP.Location = new System.Drawing.Point(387, 5);
            this.btnHuySP.Name = "btnHuySP";
            this.btnHuySP.Size = new System.Drawing.Size(90, 40);
            this.btnHuySP.TabIndex = 55;
            this.btnHuySP.Text = "Hủy";
            this.btnHuySP.UseVisualStyleBackColor = false;
            this.btnHuySP.Click += new System.EventHandler(this.btnHuySP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(195, 5);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(90, 40);
            this.btnXoaSP.TabIndex = 58;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(3, 5);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(90, 40);
            this.btnThemSP.TabIndex = 56;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLuuSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuSP.FlatAppearance.BorderSize = 0;
            this.btnLuuSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuSP.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuSP.ForeColor = System.Drawing.Color.White;
            this.btnLuuSP.Location = new System.Drawing.Point(291, 5);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(90, 40);
            this.btnLuuSP.TabIndex = 57;
            this.btnLuuSP.Text = "Lưu";
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSP_Click);
            // 
            // txbSoLuongSP
            // 
            this.txbSoLuongSP.BackColor = System.Drawing.Color.White;
            this.txbSoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoLuongSP.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbSoLuongSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txbSoLuongSP.Location = new System.Drawing.Point(196, 131);
            this.txbSoLuongSP.Name = "txbSoLuongSP";
            this.txbSoLuongSP.Size = new System.Drawing.Size(99, 23);
            this.txbSoLuongSP.TabIndex = 77;
            // 
            // txbTextSP
            // 
            this.txbTextSP.BackColor = System.Drawing.Color.White;
            this.txbTextSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTextSP.Location = new System.Drawing.Point(745, 33);
            this.txbTextSP.Name = "txbTextSP";
            this.txbTextSP.Size = new System.Drawing.Size(231, 23);
            this.txbTextSP.TabIndex = 75;
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.ForeColor = System.Drawing.Color.White;
            this.btnTimSP.Location = new System.Drawing.Point(982, 26);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(102, 34);
            this.btnTimSP.TabIndex = 74;
            this.btnTimSP.Text = "Tìm kiếm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Loại sản phẩm";
            // 
            // cbLoaiSPham
            // 
            this.cbLoaiSPham.BackColor = System.Drawing.Color.White;
            this.cbLoaiSPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSPham.FormattingEnabled = true;
            this.cbLoaiSPham.Location = new System.Drawing.Point(16, 33);
            this.cbLoaiSPham.Name = "cbLoaiSPham";
            this.cbLoaiSPham.Size = new System.Drawing.Size(151, 23);
            this.cbLoaiSPham.TabIndex = 57;
            this.cbLoaiSPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSPham_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(192, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(92, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mã SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(191, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hãng sản xuất";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(310, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Đơn giá bán";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cbHangSX
            // 
            this.cbHangSX.BackColor = System.Drawing.Color.White;
            this.cbHangSX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangSX.FormattingEnabled = true;
            this.cbHangSX.Items.AddRange(new object[] {
            "ASUS",
            "ASER",
            "DELL",
            "APPLE",
            "LENOVO",
            "MSI",
            "RAZER",
            "MICROSOFT"});
            this.cbHangSX.Location = new System.Drawing.Point(195, 82);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(105, 23);
            this.cbHangSX.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(192, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Tên sản phẩm";
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 584);
            this.Controls.Add(this.panel1);
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.fProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBaoHanh)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbSoLuongSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiSPham;
        private System.Windows.Forms.TextBox txbTextSP;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnHuySP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.TextBox txbMaSP;
        private System.Windows.Forms.TextBox txbDonGiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.TextBox txbMaLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHangSX;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTieuchiSP;
        private System.Windows.Forms.NumericUpDown txbSoLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaoHanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmBaoHanh;
        private System.Windows.Forms.Button btnNhapKho;
    }
}