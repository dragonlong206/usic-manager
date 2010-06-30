namespace GUI
{
    partial class DiemDanhHoatDongFrm
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
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTenHoatDong = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtTenHoatDong = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemHoiVien = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.grbHoatDong = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            this.grbHoatDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(226, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "ĐIỂM DANH";
            // 
            // Chon
            // 
            this.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // lblTenHoatDong
            // 
            this.lblTenHoatDong.AutoSize = true;
            this.lblTenHoatDong.Location = new System.Drawing.Point(9, 22);
            this.lblTenHoatDong.Name = "lblTenHoatDong";
            this.lblTenHoatDong.Size = new System.Drawing.Size(78, 13);
            this.lblTenHoatDong.TabIndex = 8;
            this.lblTenHoatDong.Text = "Tên hoạt động";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(251, 357);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(11, 96);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(49, 13);
            this.lblDiaDiem.TabIndex = 7;
            this.lblDiaDiem.Text = "Địa điểm";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(9, 58);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(51, 13);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(489, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(97, 55);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(109, 20);
            this.txtThoiGian.TabIndex = 1;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 50;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(97, 93);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.ReadOnly = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(109, 20);
            this.txtDiaDiem.TabIndex = 1;
            // 
            // txtTenHoatDong
            // 
            this.txtTenHoatDong.Location = new System.Drawing.Point(97, 19);
            this.txtTenHoatDong.Name = "txtTenHoatDong";
            this.txtTenHoatDong.Size = new System.Drawing.Size(109, 20);
            this.txtTenHoatDong.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // btnThemHoiVien
            // 
            this.btnThemHoiVien.Location = new System.Drawing.Point(122, 149);
            this.btnThemHoiVien.Name = "btnThemHoiVien";
            this.btnThemHoiVien.Size = new System.Drawing.Size(84, 28);
            this.btnThemHoiVien.TabIndex = 6;
            this.btnThemHoiVien.Text = "Thêm hội viên";
            this.btnThemHoiVien.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Chon});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(320, 332);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(12, 149);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm hội viên";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.comboBox1);
            this.grbThongTin.Controls.Add(this.lblVaiTro);
            this.grbThongTin.Controls.Add(this.btnThemHoiVien);
            this.grbThongTin.Controls.Add(this.btnTimKiem);
            this.grbThongTin.Controls.Add(this.btnGhiNhan);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lblHoTen);
            this.grbThongTin.Controls.Add(this.txtMSSV);
            this.grbThongTin.Controls.Add(this.lblMSSV);
            this.grbThongTin.Location = new System.Drawing.Point(10, 192);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(212, 225);
            this.grbThongTin.TabIndex = 9;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hội viên";
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(11, 183);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(195, 26);
            this.btnGhiNhan.TabIndex = 4;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(51, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(155, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(8, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(51, 21);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(155, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(8, 24);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.btnLuu);
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(232, 31);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(332, 386);
            this.grbDanhSach.TabIndex = 10;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách điểm danh";
            // 
            // grbHoatDong
            // 
            this.grbHoatDong.Controls.Add(this.lblTenHoatDong);
            this.grbHoatDong.Controls.Add(this.lblCap);
            this.grbHoatDong.Controls.Add(this.lblDiaDiem);
            this.grbHoatDong.Controls.Add(this.lblThoiGian);
            this.grbHoatDong.Controls.Add(this.txtThoiGian);
            this.grbHoatDong.Controls.Add(this.textBox1);
            this.grbHoatDong.Controls.Add(this.txtDiaDiem);
            this.grbHoatDong.Controls.Add(this.txtTenHoatDong);
            this.grbHoatDong.Location = new System.Drawing.Point(10, 31);
            this.grbHoatDong.Name = "grbHoatDong";
            this.grbHoatDong.Size = new System.Drawing.Size(212, 155);
            this.grbHoatDong.TabIndex = 12;
            this.grbHoatDong.TabStop = false;
            this.grbHoatDong.Text = "Thông tin buổi sinh hoạt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(11, 132);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(26, 13);
            this.lblCap.TabIndex = 7;
            this.lblCap.Text = "Cấp";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(12, 115);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(37, 13);
            this.lblVaiTro.TabIndex = 7;
            this.lblVaiTro.Text = "Vai trò";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // DiemDanhHoatDongFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 459);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbHoatDong);
            this.Name = "DiemDanhHoatDongFrm";
            this.Text = "DiemDanhHoatDongFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            this.grbHoatDong.ResumeLayout(false);
            this.grbHoatDong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.Label lblTenHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtTenHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnThemHoiVien;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.GroupBox grbHoatDong;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}