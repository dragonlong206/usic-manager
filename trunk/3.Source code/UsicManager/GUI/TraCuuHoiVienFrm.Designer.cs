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
            this.grbTieuChi = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.chkTimChinhXac = new System.Windows.Forms.CheckBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.btnLayEmail = new System.Windows.Forms.Button();
            this.btnInKetQua = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTieuChi.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(241, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "TRA CỨU THÔNG TIN HỘI VIÊN";
            // 
            // grbTieuChi
            // 
            this.grbTieuChi.Controls.Add(this.btnTim);
            this.grbTieuChi.Controls.Add(this.chkTimChinhXac);
            this.grbTieuChi.Controls.Add(this.txtMSSV);
            this.grbTieuChi.Controls.Add(this.lblMSSV);
            this.grbTieuChi.Controls.Add(this.txtHoTen);
            this.grbTieuChi.Controls.Add(this.lblHoTen);
            this.grbTieuChi.Location = new System.Drawing.Point(12, 43);
            this.grbTieuChi.Name = "grbTieuChi";
            this.grbTieuChi.Size = new System.Drawing.Size(784, 88);
            this.grbTieuChi.TabIndex = 3;
            this.grbTieuChi.TabStop = false;
            this.grbTieuChi.Text = "Tiêu chí tra cứu";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Location = new System.Drawing.Point(212, 59);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(360, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // chkTimChinhXac
            // 
            this.chkTimChinhXac.AutoSize = true;
            this.chkTimChinhXac.Location = new System.Drawing.Point(606, 20);
            this.chkTimChinhXac.Name = "chkTimChinhXac";
            this.chkTimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chkTimChinhXac.TabIndex = 4;
            this.chkTimChinhXac.Text = "Tìm chính xác";
            this.chkTimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(341, 17);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(142, 20);
            this.txtMSSV.TabIndex = 3;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(298, 20);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 2;
            this.lblMSSV.Text = "MSSV";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(52, 17);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.btnLayEmail);
            this.grbKetQua.Controls.Add(this.btnInKetQua);
            this.grbKetQua.Controls.Add(this.btnXemChiTiet);
            this.grbKetQua.Controls.Add(this.dgvDanhSach);
            this.grbKetQua.Location = new System.Drawing.Point(13, 152);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(783, 361);
            this.grbKetQua.TabIndex = 4;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả tra cứu";
            // 
            // btnLayEmail
            // 
            this.btnLayEmail.Location = new System.Drawing.Point(105, 331);
            this.btnLayEmail.Name = "btnLayEmail";
            this.btnLayEmail.Size = new System.Drawing.Size(114, 23);
            this.btnLayEmail.TabIndex = 3;
            this.btnLayEmail.Text = "Lấy danh sách email";
            this.btnLayEmail.UseVisualStyleBackColor = true;
            // 
            // btnInKetQua
            // 
            this.btnInKetQua.Location = new System.Drawing.Point(243, 331);
            this.btnInKetQua.Name = "btnInKetQua";
            this.btnInKetQua.Size = new System.Drawing.Size(91, 23);
            this.btnInKetQua.TabIndex = 2;
            this.btnInKetQua.Text = "In danh sách";
            this.btnInKetQua.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(7, 331);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Email,
            this.DienThoai,
            this.DRL});
            this.dgvDanhSach.Location = new System.Drawing.Point(9, 20);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(768, 305);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentDoubleClick);
            // 
            // STT
            // 
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 80;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DienThoai
            // 
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // DRL
            // 
            this.DRL.HeaderText = "DRL";
            this.DRL.Name = "DRL";
            this.DRL.Width = 50;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(721, 524);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // TraCuuHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.grbTieuChi);
            this.Controls.Add(this.lblTitle);
            this.Name = "TraCuuHoiVienFrm";
            this.Text = "TraCuuHoiVienFrm";
            this.grbTieuChi.ResumeLayout(false);
            this.grbTieuChi.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbTieuChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.CheckBox chkTimChinhXac;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRL;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnInKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLayEmail;
    }
}