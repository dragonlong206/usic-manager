namespace GUI
{
    partial class DiemDanhFrm
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
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemHoiVien = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(231, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ĐIỂM DANH";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnThemHoiVien);
            this.grbThongTin.Controls.Add(this.btnTimKiem);
            this.grbThongTin.Controls.Add(this.btnGhiNhan);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lblHoTen);
            this.grbThongTin.Controls.Add(this.txtMSSV);
            this.grbThongTin.Controls.Add(this.lblMSSV);
            this.grbThongTin.Location = new System.Drawing.Point(13, 36);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(212, 386);
            this.grbThongTin.TabIndex = 4;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hội viên";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.btnLuu);
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(235, 36);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(332, 386);
            this.grbDanhSach.TabIndex = 5;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách điểm danh";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(7, 33);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(50, 30);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(155, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 83);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(50, 80);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(155, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(10, 192);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(195, 26);
            this.btnGhiNhan.TabIndex = 4;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(11, 139);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm hội viên";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemHoiVien
            // 
            this.btnThemHoiVien.Location = new System.Drawing.Point(121, 139);
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
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // Chon
            // 
            this.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(492, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // DiemDanhFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 453);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "DiemDanhFrm";
            this.Text = "DiemDanhFrm";
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Button btnThemHoiVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}