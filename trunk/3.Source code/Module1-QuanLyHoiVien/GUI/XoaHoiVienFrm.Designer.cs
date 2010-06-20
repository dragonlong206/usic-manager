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
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.grbTieuChi = new System.Windows.Forms.GroupBox();
            this.chkTimChinhXac = new System.Windows.Forms.CheckBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbTieuChi.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(329, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "XÓA HỘI VIÊN";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.STT,
            this.MSSV,
            this.HoTen,
            this.DRL});
            this.dgvDanhSach.Location = new System.Drawing.Point(7, 19);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(485, 379);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.Width = 35;
            // 
            // STT
            // 
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
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // DRL
            // 
            this.DRL.HeaderText = "DRL";
            this.DRL.Name = "DRL";
            this.DRL.Width = 50;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(140, 110);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // grbTieuChi
            // 
            this.grbTieuChi.Controls.Add(this.btnTim);
            this.grbTieuChi.Controls.Add(this.chkTimChinhXac);
            this.grbTieuChi.Controls.Add(this.txtMSSV);
            this.grbTieuChi.Controls.Add(this.lblMSSV);
            this.grbTieuChi.Controls.Add(this.txtHoTen);
            this.grbTieuChi.Controls.Add(this.lblHoTen);
            this.grbTieuChi.Location = new System.Drawing.Point(22, 56);
            this.grbTieuChi.Name = "grbTieuChi";
            this.grbTieuChi.Size = new System.Drawing.Size(225, 434);
            this.grbTieuChi.TabIndex = 7;
            this.grbTieuChi.TabStop = false;
            this.grbTieuChi.Text = "Tìm kiếm hội viên";
            // 
            // chkTimChinhXac
            // 
            this.chkTimChinhXac.AutoSize = true;
            this.chkTimChinhXac.Location = new System.Drawing.Point(12, 116);
            this.chkTimChinhXac.Name = "chkTimChinhXac";
            this.chkTimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chkTimChinhXac.TabIndex = 4;
            this.chkTimChinhXac.Text = "Tìm chính xác";
            this.chkTimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(52, 76);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(163, 20);
            this.txtMSSV.TabIndex = 3;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(9, 79);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 2;
            this.lblMSSV.Text = "MSSV";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(52, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(163, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(7, 39);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(702, 496);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.btnChon);
            this.grbKetQua.Controls.Add(this.btnXoa);
            this.grbKetQua.Controls.Add(this.dgvDanhSach);
            this.grbKetQua.Location = new System.Drawing.Point(279, 56);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(498, 434);
            this.grbKetQua.TabIndex = 8;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả tra cứu";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(6, 404);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(128, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn tất cả";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // XoaHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 524);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbTieuChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbKetQua);
            this.Name = "XoaHoiVienFrm";
            this.Text = "XoaHoiVienFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbTieuChi.ResumeLayout(false);
            this.grbTieuChi.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grbTieuChi;
        private System.Windows.Forms.CheckBox chkTimChinhXac;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRL;
        private System.Windows.Forms.Button btnChon;
    }
}