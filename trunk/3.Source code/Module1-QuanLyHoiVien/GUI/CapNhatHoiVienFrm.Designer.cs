namespace GUI
{
    partial class CapNhatHoiVienFrm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.cboTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.lsvDanhSachHoiVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.grbThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.txtDiaChiThuongTru = new System.Windows.Forms.TextBox();
            this.lblThuongTru = new System.Windows.Forms.Label();
            this.txtChoO = new System.Windows.Forms.TextBox();
            this.lblChoO = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboEmail_Domain = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.grbThongTinHoiVien = new System.Windows.Forms.GroupBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboLoaiHoiVien = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLoaiHoiVien = new System.Windows.Forms.Label();
            this.grbThongTinDoanHoi = new System.Windows.Forms.GroupBox();
            this.chkHoiVien = new System.Windows.Forms.CheckBox();
            this.chkDangVien = new System.Windows.Forms.CheckBox();
            this.chkDoanVien = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grbThongTinCaNhan.SuspendLayout();
            this.grbThongTinHoiVien.SuspendLayout();
            this.grbThongTinDoanHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 516);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(351, 516);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(270, 516);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN HỘI VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaTriTimKiem);
            this.groupBox1.Controls.Add(this.cboTieuChiTimKiem);
            this.groupBox1.Controls.Add(this.chk_TimChinhXac);
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.lsvDanhSachHoiVien);
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 187);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu danh sách hội viên";
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(134, 25);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txtGiaTriTimKiem.TabIndex = 36;
            // 
            // cboTieuChiTimKiem
            // 
            this.cboTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChiTimKiem.FormattingEnabled = true;
            this.cboTieuChiTimKiem.Items.AddRange(new object[] {
            "MSSV",
            "Họ tên"});
            this.cboTieuChiTimKiem.Location = new System.Drawing.Point(21, 23);
            this.cboTieuChiTimKiem.Name = "cboTieuChiTimKiem";
            this.cboTieuChiTimKiem.Size = new System.Drawing.Size(104, 21);
            this.cboTieuChiTimKiem.TabIndex = 35;
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(387, 27);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 34;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(297, 23);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 33;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // lsvDanhSachHoiVien
            // 
            this.lsvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Email});
            this.lsvDanhSachHoiVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvDanhSachHoiVien.FullRowSelect = true;
            this.lsvDanhSachHoiVien.GridLines = true;
            this.lsvDanhSachHoiVien.Location = new System.Drawing.Point(3, 52);
            this.lsvDanhSachHoiVien.Name = "lsvDanhSachHoiVien";
            this.lsvDanhSachHoiVien.Size = new System.Drawing.Size(488, 132);
            this.lsvDanhSachHoiVien.TabIndex = 0;
            this.lsvDanhSachHoiVien.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachHoiVien.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachHoiVien.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachHoiVien_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 36;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 70;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 150;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 205;
            // 
            // grbThongTinCaNhan
            // 
            this.grbThongTinCaNhan.Controls.Add(this.txtDiaChiThuongTru);
            this.grbThongTinCaNhan.Controls.Add(this.lblThuongTru);
            this.grbThongTinCaNhan.Controls.Add(this.txtChoO);
            this.grbThongTinCaNhan.Controls.Add(this.lblChoO);
            this.grbThongTinCaNhan.Controls.Add(this.txtDienThoai);
            this.grbThongTinCaNhan.Controls.Add(this.label5);
            this.grbThongTinCaNhan.Controls.Add(this.txtHoTen);
            this.grbThongTinCaNhan.Controls.Add(this.cboEmail_Domain);
            this.grbThongTinCaNhan.Controls.Add(this.lblHoTen);
            this.grbThongTinCaNhan.Controls.Add(this.lblDienThoai);
            this.grbThongTinCaNhan.Controls.Add(this.txtEmail);
            this.grbThongTinCaNhan.Controls.Add(this.lblMSSV);
            this.grbThongTinCaNhan.Controls.Add(this.lblEmail);
            this.grbThongTinCaNhan.Controls.Add(this.txtMSSV);
            this.grbThongTinCaNhan.Location = new System.Drawing.Point(12, 253);
            this.grbThongTinCaNhan.Name = "grbThongTinCaNhan";
            this.grbThongTinCaNhan.Size = new System.Drawing.Size(494, 147);
            this.grbThongTinCaNhan.TabIndex = 14;
            this.grbThongTinCaNhan.TabStop = false;
            this.grbThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // txtDiaChiThuongTru
            // 
            this.txtDiaChiThuongTru.Location = new System.Drawing.Point(123, 121);
            this.txtDiaChiThuongTru.Name = "txtDiaChiThuongTru";
            this.txtDiaChiThuongTru.Size = new System.Drawing.Size(352, 20);
            this.txtDiaChiThuongTru.TabIndex = 8;
            // 
            // lblThuongTru
            // 
            this.lblThuongTru.AutoSize = true;
            this.lblThuongTru.Location = new System.Drawing.Point(17, 124);
            this.lblThuongTru.Name = "lblThuongTru";
            this.lblThuongTru.Size = new System.Drawing.Size(91, 13);
            this.lblThuongTru.TabIndex = 7;
            this.lblThuongTru.Text = "Địa chỉ thường trú";
            // 
            // txtChoO
            // 
            this.txtChoO.Location = new System.Drawing.Point(123, 93);
            this.txtChoO.Name = "txtChoO";
            this.txtChoO.Size = new System.Drawing.Size(352, 20);
            this.txtChoO.TabIndex = 6;
            // 
            // lblChoO
            // 
            this.lblChoO.AutoSize = true;
            this.lblChoO.Location = new System.Drawing.Point(17, 96);
            this.lblChoO.Name = "lblChoO";
            this.lblChoO.Size = new System.Drawing.Size(72, 13);
            this.lblChoO.TabIndex = 5;
            this.lblChoO.Text = "Chỗ ở hiện tại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(80, 58);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "@";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(258, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(218, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // cboEmail_Domain
            // 
            this.cboEmail_Domain.FormattingEnabled = true;
            this.cboEmail_Domain.Items.AddRange(new object[] {
            "gmail.com",
            "yahoo.com",
            "yahoo.com.vn",
            "student.hcmus.edu.vn"});
            this.cboEmail_Domain.Location = new System.Drawing.Point(386, 57);
            this.cboEmail_Domain.Name = "cboEmail_Domain";
            this.cboEmail_Domain.Size = new System.Drawing.Size(90, 21);
            this.cboEmail_Domain.TabIndex = 2;
            this.cboEmail_Domain.Text = "gmail.com";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(200, 22);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(17, 61);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(258, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(104, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(17, 22);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Location = new System.Drawing.Point(79, 19);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(101, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // grbThongTinHoiVien
            // 
            this.grbThongTinHoiVien.Controls.Add(this.cboChucVu);
            this.grbThongTinHoiVien.Controls.Add(this.cboLoaiHoiVien);
            this.grbThongTinHoiVien.Controls.Add(this.lblChucVu);
            this.grbThongTinHoiVien.Controls.Add(this.lblLoaiHoiVien);
            this.grbThongTinHoiVien.Location = new System.Drawing.Point(273, 417);
            this.grbThongTinHoiVien.Name = "grbThongTinHoiVien";
            this.grbThongTinHoiVien.Size = new System.Drawing.Size(235, 83);
            this.grbThongTinHoiVien.TabIndex = 12;
            this.grbThongTinHoiVien.TabStop = false;
            this.grbThongTinHoiVien.Text = "Thông tin hội viên";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(117, 54);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(100, 21);
            this.cboChucVu.TabIndex = 3;
            // 
            // cboLoaiHoiVien
            // 
            this.cboLoaiHoiVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHoiVien.FormattingEnabled = true;
            this.cboLoaiHoiVien.Location = new System.Drawing.Point(117, 16);
            this.cboLoaiHoiVien.Name = "cboLoaiHoiVien";
            this.cboLoaiHoiVien.Size = new System.Drawing.Size(100, 21);
            this.cboLoaiHoiVien.TabIndex = 2;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(17, 58);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(47, 13);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblLoaiHoiVien
            // 
            this.lblLoaiHoiVien.AutoSize = true;
            this.lblLoaiHoiVien.Location = new System.Drawing.Point(17, 19);
            this.lblLoaiHoiVien.Name = "lblLoaiHoiVien";
            this.lblLoaiHoiVien.Size = new System.Drawing.Size(67, 13);
            this.lblLoaiHoiVien.TabIndex = 0;
            this.lblLoaiHoiVien.Text = "Loại hội viên";
            // 
            // grbThongTinDoanHoi
            // 
            this.grbThongTinDoanHoi.Controls.Add(this.chkHoiVien);
            this.grbThongTinDoanHoi.Controls.Add(this.chkDangVien);
            this.grbThongTinDoanHoi.Controls.Add(this.chkDoanVien);
            this.grbThongTinDoanHoi.Location = new System.Drawing.Point(13, 417);
            this.grbThongTinDoanHoi.Name = "grbThongTinDoanHoi";
            this.grbThongTinDoanHoi.Size = new System.Drawing.Size(235, 83);
            this.grbThongTinDoanHoi.TabIndex = 13;
            this.grbThongTinDoanHoi.TabStop = false;
            this.grbThongTinDoanHoi.Text = "Thông tin Đoàn Hội";
            // 
            // chkHoiVien
            // 
            this.chkHoiVien.AutoSize = true;
            this.chkHoiVien.Location = new System.Drawing.Point(19, 58);
            this.chkHoiVien.Name = "chkHoiVien";
            this.chkHoiVien.Size = new System.Drawing.Size(80, 17);
            this.chkHoiVien.TabIndex = 0;
            this.chkHoiVien.Text = "Là Hội viên";
            this.chkHoiVien.UseVisualStyleBackColor = true;
            // 
            // chkDangVien
            // 
            this.chkDangVien.AutoSize = true;
            this.chkDangVien.Location = new System.Drawing.Point(132, 20);
            this.chkDangVien.Name = "chkDangVien";
            this.chkDangVien.Size = new System.Drawing.Size(90, 17);
            this.chkDangVien.TabIndex = 0;
            this.chkDangVien.Text = "Là Đảng viên";
            this.chkDangVien.UseVisualStyleBackColor = true;
            // 
            // chkDoanVien
            // 
            this.chkDoanVien.AutoSize = true;
            this.chkDoanVien.Location = new System.Drawing.Point(19, 20);
            this.chkDoanVien.Name = "chkDoanVien";
            this.chkDoanVien.Size = new System.Drawing.Size(90, 17);
            this.chkDoanVien.TabIndex = 0;
            this.chkDoanVien.Text = "Là Đoàn viên";
            this.chkDoanVien.UseVisualStyleBackColor = true;
            // 
            // CapNhatHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinCaNhan);
            this.Controls.Add(this.grbThongTinHoiVien);
            this.Controls.Add(this.grbThongTinDoanHoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblTitle);
            this.Name = "CapNhatHoiVienFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatHoiVienFrm";
            this.Load += new System.EventHandler(this.CapNhatHoiVienFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbThongTinCaNhan.ResumeLayout(false);
            this.grbThongTinCaNhan.PerformLayout();
            this.grbThongTinHoiVien.ResumeLayout(false);
            this.grbThongTinHoiVien.PerformLayout();
            this.grbThongTinDoanHoi.ResumeLayout(false);
            this.grbThongTinDoanHoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSachHoiVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.GroupBox grbThongTinCaNhan;
        private System.Windows.Forms.TextBox txtDiaChiThuongTru;
        private System.Windows.Forms.Label lblThuongTru;
        private System.Windows.Forms.TextBox txtChoO;
        private System.Windows.Forms.Label lblChoO;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboEmail_Domain;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.GroupBox grbThongTinHoiVien;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboLoaiHoiVien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLoaiHoiVien;
        private System.Windows.Forms.GroupBox grbThongTinDoanHoi;
        private System.Windows.Forms.CheckBox chkHoiVien;
        private System.Windows.Forms.CheckBox chkDangVien;
        private System.Windows.Forms.CheckBox chkDoanVien;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.ComboBox cboTieuChiTimKiem;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.Button btn_Tim;

    }
}