namespace QLBanHangLapTop
{
    partial class fStaff
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
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTieuChi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTimNV = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnHuyNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTieuChi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbTimNV);
            this.panel1.Controls.Add(this.txbDiaChi);
            this.panel1.Controls.Add(this.btnTimSP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txbMaNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbTenNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbSDT);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 128);
            this.panel1.TabIndex = 0;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.White;
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(27, 82);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(65, 23);
            this.cbGioiTinh.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(493, 12);
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
            "Tên nhân viên",
            "Mã nhân viên"});
            this.cbTieuChi.Location = new System.Drawing.Point(497, 35);
            this.cbTieuChi.Name = "cbTieuChi";
            this.cbTieuChi.Size = new System.Drawing.Size(124, 23);
            this.cbTieuChi.TabIndex = 90;
            this.cbTieuChi.Text = "Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(103, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Địa chỉ";
            // 
            // tbTimNV
            // 
            this.tbTimNV.BackColor = System.Drawing.Color.White;
            this.tbTimNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbTimNV.Location = new System.Drawing.Point(633, 34);
            this.tbTimNV.Name = "tbTimNV";
            this.tbTimNV.Size = new System.Drawing.Size(242, 23);
            this.tbTimNV.TabIndex = 89;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BackColor = System.Drawing.Color.White;
            this.txbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbDiaChi.Location = new System.Drawing.Point(107, 82);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(338, 23);
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
            this.btnTimSP.Location = new System.Drawing.Point(881, 30);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(90, 32);
            this.btnTimSP.TabIndex = 88;
            this.btnTimSP.Text = "Tìm kiếm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaNV);
            this.panel2.Controls.Add(this.btnHuyNV);
            this.panel2.Controls.Add(this.btnXoaNV);
            this.panel2.Controls.Add(this.btnThemNV);
            this.panel2.Controls.Add(this.btnLuuNV);
            this.panel2.Location = new System.Drawing.Point(473, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 46);
            this.panel2.TabIndex = 74;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Location = new System.Drawing.Point(216, 3);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(90, 40);
            this.btnSuaNV.TabIndex = 59;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnHuyNV
            // 
            this.btnHuyNV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHuyNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyNV.FlatAppearance.BorderSize = 0;
            this.btnHuyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyNV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuyNV.ForeColor = System.Drawing.Color.White;
            this.btnHuyNV.Location = new System.Drawing.Point(408, 3);
            this.btnHuyNV.Name = "btnHuyNV";
            this.btnHuyNV.Size = new System.Drawing.Size(90, 40);
            this.btnHuyNV.TabIndex = 55;
            this.btnHuyNV.Text = "Hủy";
            this.btnHuyNV.UseVisualStyleBackColor = false;
            this.btnHuyNV.Click += new System.EventHandler(this.btnHuyNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(120, 3);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(90, 40);
            this.btnXoaNV.TabIndex = 58;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(24, 3);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(90, 40);
            this.btnThemNV.TabIndex = 56;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLuuNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNV.FlatAppearance.BorderSize = 0;
            this.btnLuuNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuNV.ForeColor = System.Drawing.Color.White;
            this.btnLuuNV.Location = new System.Drawing.Point(312, 3);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(90, 39);
            this.btnLuuNV.TabIndex = 57;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.UseVisualStyleBackColor = false;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(23, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Giới tính";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(252, 34);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(91, 23);
            this.dtpkNgaySinh.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(248, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Ngày sinh";
            // 
            // txbMaNV
            // 
            this.txbMaNV.BackColor = System.Drawing.Color.White;
            this.txbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbMaNV.Location = new System.Drawing.Point(27, 34);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(65, 23);
            this.txbMaNV.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(345, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số điện thoại";
            // 
            // txbTenNV
            // 
            this.txbTenNV.BackColor = System.Drawing.Color.White;
            this.txbTenNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTenNV.Location = new System.Drawing.Point(107, 34);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(139, 23);
            this.txbTenNV.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(23, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã NV";
            // 
            // txbSDT
            // 
            this.txbSDT.BackColor = System.Drawing.Color.White;
            this.txbSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbSDT.Location = new System.Drawing.Point(349, 34);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(96, 23);
            this.txbSDT.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(103, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Tên nhân viên";
            // 
            // dtgvStaff
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dtgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.diaChi,
            this.dienThoai,
            this.ngaySinh,
            this.gioiTinh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvStaff.GridColor = System.Drawing.Color.Lavender;
            this.dtgvStaff.Location = new System.Drawing.Point(24, 186);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvStaff.Size = new System.Drawing.Size(1001, 299);
            this.dtgvStaff.TabIndex = 26;
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            this.maNV.Width = 87;
            // 
            // tenNV
            // 
            this.tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.FillWeight = 200F;
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 180;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // dienThoai
            // 
            this.dienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "Điện thoại";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.Width = 115;
            // 
            // ngaySinh
            // 
            this.ngaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 112;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(516, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nhân viên";
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvStaff);
            this.Controls.Add(this.panel1);
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnHuyNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTieuChi;
        private System.Windows.Forms.TextBox tbTimNV;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
    }
}