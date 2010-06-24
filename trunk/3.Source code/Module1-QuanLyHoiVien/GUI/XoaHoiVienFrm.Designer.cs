namespace GUI
{
    partial class XoaHoiVienFrm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChonTatCa = new System.Windows.Forms.CheckBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lsvDanhSachHoiVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MSSV = new System.Windows.Forms.ColumnHeader();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.txtGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.cboTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(189, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "XÓA HỘI VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(425, 516);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChonTatCa);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.lsvDanhSachHoiVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 352);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tra cứu";
            // 
            // chkChonTatCa
            // 
            this.chkChonTatCa.AutoSize = true;
            this.chkChonTatCa.Location = new System.Drawing.Point(13, 330);
            this.chkChonTatCa.Name = "chkChonTatCa";
            this.chkChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chkChonTatCa.TabIndex = 35;
            this.chkChonTatCa.Text = "Chọn tất cả";
            this.chkChonTatCa.UseVisualStyleBackColor = true;
            this.chkChonTatCa.CheckedChanged += new System.EventHandler(this.chkChonTatCa_CheckedChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(413, 325);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lsvDanhSachHoiVien
            // 
            this.lsvDanhSachHoiVien.CheckBoxes = true;
            this.lsvDanhSachHoiVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Email});
            this.lsvDanhSachHoiVien.FullRowSelect = true;
            this.lsvDanhSachHoiVien.GridLines = true;
            this.lsvDanhSachHoiVien.Location = new System.Drawing.Point(3, 19);
            this.lsvDanhSachHoiVien.Name = "lsvDanhSachHoiVien";
            this.lsvDanhSachHoiVien.Size = new System.Drawing.Size(488, 300);
            this.lsvDanhSachHoiVien.TabIndex = 0;
            this.lsvDanhSachHoiVien.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachHoiVien.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 45;
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
            this.Email.Width = 195;
            // 
            // txtGiaTriTimKiem
            // 
            this.txtGiaTriTimKiem.Location = new System.Drawing.Point(139, 33);
            this.txtGiaTriTimKiem.Name = "txtGiaTriTimKiem";
            this.txtGiaTriTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txtGiaTriTimKiem.TabIndex = 40;
            // 
            // cboTieuChiTimKiem
            // 
            this.cboTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChiTimKiem.FormattingEnabled = true;
            this.cboTieuChiTimKiem.Items.AddRange(new object[] {
            "MSSV",
            "Họ tên"});
            this.cboTieuChiTimKiem.Location = new System.Drawing.Point(13, 33);
            this.cboTieuChiTimKiem.Name = "cboTieuChiTimKiem";
            this.cboTieuChiTimKiem.Size = new System.Drawing.Size(120, 21);
            this.cboTieuChiTimKiem.TabIndex = 39;
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(394, 35);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 38;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(302, 31);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 37;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaTriTimKiem);
            this.groupBox2.Controls.Add(this.btn_Tim);
            this.groupBox2.Controls.Add(this.cboTieuChiTimKiem);
            this.groupBox2.Controls.Add(this.chk_TimChinhXac);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 92);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu danh sách hội viên";
            // 
            // XoaHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoat);
            this.Name = "XoaHoiVienFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaHoiVienFrm";
            this.Load += new System.EventHandler(this.XoaHoiVienFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSachHoiVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.TextBox txtGiaTriTimKiem;
        private System.Windows.Forms.ComboBox cboTieuChiTimKiem;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkChonTatCa;
        private System.Windows.Forms.Button btn_Xoa;
    }
}