namespace QLBanHangLapTop
{
    partial class fCustomer
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
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSDTMaKH = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txbTimKH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnHuyKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTieuchiKH = new System.Windows.Forms.ComboBox();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvKhachHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.dtgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.tenKH,
            this.diaChi,
            this.dienThoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvKhachHang.GridColor = System.Drawing.Color.Lavender;
            this.dtgvKhachHang.Location = new System.Drawing.Point(27, 228);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvKhachHang.Size = new System.Drawing.Size(1292, 383);
            this.dtgvKhachHang.TabIndex = 26;
            // 
            // maKH
            // 
            this.maKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Mã khách";
            this.maKH.Name = "maKH";
            this.maKH.Width = 133;
            // 
            // tenKH
            // 
            this.tenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.FillWeight = 200F;
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.Name = "tenKH";
            this.tenKH.Width = 200;
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
            this.dienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "Số điện thoại";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.Width = 109;
            // 
            // txbSDTMaKH
            // 
            this.txbSDTMaKH.BackColor = System.Drawing.Color.White;
            this.txbSDTMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbSDTMaKH.Location = new System.Drawing.Point(384, 43);
            this.txbSDTMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSDTMaKH.Name = "txbSDTMaKH";
            this.txbSDTMaKH.Size = new System.Drawing.Size(147, 27);
            this.txbSDTMaKH.TabIndex = 80;
            this.txbSDTMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDTMaKH_KeyPress);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BackColor = System.Drawing.Color.White;
            this.txbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbDiaChi.Location = new System.Drawing.Point(25, 103);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(505, 27);
            this.txbDiaChi.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(20, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Địa chỉ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(379, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Số điện thoại";
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKH.FlatAppearance.BorderSize = 0;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKH.Location = new System.Drawing.Point(1147, 36);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(121, 39);
            this.btnTimKH.TabIndex = 74;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txbTimKH
            // 
            this.txbTimKH.BackColor = System.Drawing.Color.White;
            this.txbTimKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTimKH.Location = new System.Drawing.Point(816, 41);
            this.txbTimKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTimKH.Name = "txbTimKH";
            this.txbTimKH.Size = new System.Drawing.Size(321, 27);
            this.txbTimKH.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSuaKH);
            this.panel3.Controls.Add(this.btnHuyKH);
            this.panel3.Controls.Add(this.btnXoaKH);
            this.panel3.Controls.Add(this.btnThemKH);
            this.panel3.Controls.Add(this.btnLuuKH);
            this.panel3.Location = new System.Drawing.Point(631, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 57);
            this.panel3.TabIndex = 78;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKH.FlatAppearance.BorderSize = 0;
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaKH.Location = new System.Drawing.Point(260, 4);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(120, 49);
            this.btnSuaKH.TabIndex = 59;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnHuyKH
            // 
            this.btnHuyKH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHuyKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyKH.FlatAppearance.BorderSize = 0;
            this.btnHuyKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuyKH.ForeColor = System.Drawing.Color.White;
            this.btnHuyKH.Location = new System.Drawing.Point(516, 4);
            this.btnHuyKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuyKH.Name = "btnHuyKH";
            this.btnHuyKH.Size = new System.Drawing.Size(120, 49);
            this.btnHuyKH.TabIndex = 55;
            this.btnHuyKH.Text = "Hủy";
            this.btnHuyKH.UseVisualStyleBackColor = false;
            this.btnHuyKH.Click += new System.EventHandler(this.btnHuyKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.Location = new System.Drawing.Point(132, 4);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(120, 49);
            this.btnXoaKH.TabIndex = 58;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Location = new System.Drawing.Point(4, 4);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(120, 49);
            this.btnThemKH.TabIndex = 56;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLuuKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuKH.FlatAppearance.BorderSize = 0;
            this.btnLuuKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKH.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuKH.Location = new System.Drawing.Point(388, 4);
            this.btnLuuKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(120, 49);
            this.btnLuuKH.TabIndex = 57;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.UseVisualStyleBackColor = false;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTieuchiKH);
            this.panel1.Controls.Add(this.txbTenKH);
            this.panel1.Controls.Add(this.txbMaKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbSDTMaKH);
            this.panel1.Controls.Add(this.txbDiaChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txbTimKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnTimKH);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(27, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 170);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tìm theo";
            // 
            // cbTieuchiKH
            // 
            this.cbTieuchiKH.BackColor = System.Drawing.Color.White;
            this.cbTieuchiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuchiKH.FormattingEnabled = true;
            this.cbTieuchiKH.Items.AddRange(new object[] {
            "Số điện thoại",
            "Tên khách hàng"});
            this.cbTieuchiKH.Location = new System.Drawing.Point(631, 41);
            this.cbTieuchiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTieuchiKH.Name = "cbTieuchiKH";
            this.cbTieuchiKH.Size = new System.Drawing.Size(164, 28);
            this.cbTieuchiKH.TabIndex = 86;
            this.cbTieuchiKH.Text = "Tên khách hàng";
            // 
            // txbTenKH
            // 
            this.txbTenKH.BackColor = System.Drawing.Color.White;
            this.txbTenKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbTenKH.Location = new System.Drawing.Point(116, 43);
            this.txbTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(257, 27);
            this.txbTenKH.TabIndex = 85;
            // 
            // txbMaKH
            // 
            this.txbMaKH.BackColor = System.Drawing.Color.White;
            this.txbMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txbMaKH.Location = new System.Drawing.Point(24, 43);
            this.txbMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(69, 27);
            this.txbMaKH.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(111, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(664, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 37);
            this.label8.TabIndex = 33;
            this.label8.Text = "Khách hàng";
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 633);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.TextBox txbSDTMaKH;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txbTimKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnHuyKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTieuchiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
    }
}