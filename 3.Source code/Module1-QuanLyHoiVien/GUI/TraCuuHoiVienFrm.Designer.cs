namespace GUI
{
    partial class TraCuuHoiVienFrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachHoiVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.DRL = new System.Windows.Forms.ColumnHeader();
            this.btnLayEmail = new System.Windows.Forms.Button();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaTriRangBuoc = new System.Windows.Forms.TextBox();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.cboRangBuocTiemKiem = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cboTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grbKetQua.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "TRA CỨU THÔNG TIN HỘI VIÊN";
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.Location = new System.Drawing.Point(82, 335);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(97, 23);
            this.btnXemToanBo.TabIndex = 6;
            this.btnXemToanBo.Text = "Xem toàn bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = true;
            this.btnXemToanBo.Click += new System.EventHandler(this.btnXemToanBo_Click);
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.btnXemToanBo);
            this.grbKetQua.Controls.Add(this.lsvDanhSachHoiVien);
            this.grbKetQua.Controls.Add(this.btnLayEmail);
            this.grbKetQua.Controls.Add(this.btnInDanhSach);
            this.grbKetQua.Controls.Add(this.btnXemChiTiet);
            this.grbKetQua.Location = new System.Drawing.Point(13, 150);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(609, 364);
            this.grbKetQua.TabIndex = 4;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả tra cứu";
            // 
            // lsvDanhSachHoiVien
            // 
            this.lsvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Email,
            this.DienThoai,
            this.DRL});
            this.lsvDanhSachHoiVien.FullRowSelect = true;
            this.lsvDanhSachHoiVien.GridLines = true;
            this.lsvDanhSachHoiVien.Location = new System.Drawing.Point(3, 32);
            this.lsvDanhSachHoiVien.Name = "lsvDanhSachHoiVien";
            this.lsvDanhSachHoiVien.Size = new System.Drawing.Size(606, 297);
            this.lsvDanhSachHoiVien.TabIndex = 4;
            this.lsvDanhSachHoiVien.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachHoiVien.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 36;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Email.Width = 195;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện Thoại";
            this.DienThoai.Width = 90;
            // 
            // DRL
            // 
            this.DRL.Text = "ĐRL";
            this.DRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DRL.Width = 40;
            // 
            // btnLayEmail
            // 
            this.btnLayEmail.Location = new System.Drawing.Point(424, 335);
            this.btnLayEmail.Name = "btnLayEmail";
            this.btnLayEmail.Size = new System.Drawing.Size(84, 23);
            this.btnLayEmail.TabIndex = 3;
            this.btnLayEmail.Text = "Xuất email";
            this.btnLayEmail.UseVisualStyleBackColor = true;
            this.btnLayEmail.Click += new System.EventHandler(this.btnLayEmail_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Location = new System.Drawing.Point(514, 335);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(89, 23);
            this.btnInDanhSach.TabIndex = 2;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(3, 335);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(73, 23);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(541, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaTriRangBuoc);
            this.groupBox2.Controls.Add(this.txtGiaTriTimKiem);
            this.groupBox2.Controls.Add(this.cboRangBuocTiemKiem);
            this.groupBox2.Controls.Add(this.btn_Tim);
            this.groupBox2.Controls.Add(this.cboTieuChiTimKiem);
            this.groupBox2.Controls.Add(this.chk_TimChinhXac);
            this.groupBox2.Location = new System.Drawing.Point(13, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 92);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu danh sách hội viên";
            // 
            // txtGiaTriRangBuoc
            // 
            this.txtGiaTriRangBuoc.Location = new System.Drawing.Point(436, 33);
            this.txtGiaTriRangBuoc.Name = "txtGiaTriRangBuoc";
            this.txtGiaTriRangBuoc.Size = new System.Drawing.Size(157, 20);
            this.txtGiaTriRangBuoc.TabIndex = 40;
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(139, 33);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txtGiaTriTimKiem.TabIndex = 40;
            // 
            // cboRangBuocTiemKiem
            // 
            this.cboRangBuocTiemKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRangBuocTiemKiem.FormattingEnabled = true;
            this.cboRangBuocTiemKiem.Items.AddRange(new object[] {
            "ĐRL",
            "Là Đoàn viên",
            "Là Hội viên",
            "Là Đảng viên",
            "Email",
            "Điện thoại",
            "Chỗ ở hiện nay",
            "Địa chỉ thường trú"});
            this.cboRangBuocTiemKiem.Location = new System.Drawing.Point(310, 33);
            this.cboRangBuocTiemKiem.Name = "cboRangBuocTiemKiem";
            this.cboRangBuocTiemKiem.Size = new System.Drawing.Size(120, 21);
            this.cboRangBuocTiemKiem.TabIndex = 39;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(264, 63);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 37;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // cboTieuChiTimKiem
            // 
            this.cboTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChiTimKiem.FormattingEnabled = true;
            this.cboTieuChiTimKiem.Items.AddRange(new object[] {
            "MSSV",
            "Họ tên",
            "Loại hội viên",
            "Vai trò",
            "Chuyên môn",
            "Cấp bậc chuyên môn"});
            this.cboTieuChiTimKiem.Location = new System.Drawing.Point(13, 33);
            this.cboTieuChiTimKiem.Name = "cboTieuChiTimKiem";
            this.cboTieuChiTimKiem.Size = new System.Drawing.Size(120, 21);
            this.cboTieuChiTimKiem.TabIndex = 39;
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(499, 67);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 38;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 520);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(97, 520);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(178, 520);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(77, 23);
            this.btnCapNhat.TabIndex = 43;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // TraCuuHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 551);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.lblTitle);
            this.Name = "TraCuuHoiVienFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuHoiVienFrm";
            this.Load += new System.EventHandler(this.TraCuuHoiVienFrm_Load);
            this.grbKetQua.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLayEmail;
        private System.Windows.Forms.Button btnXemToanBo;
        private System.Windows.Forms.ListView lsvDanhSachHoiVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader DRL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaTriRangBuoc;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.ComboBox cboRangBuocTiemKiem;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox cboTieuChiTimKiem;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
    }
}