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
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.chkChonTatCa = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaBuoi = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.grbBuoiSinhHoat = new System.Windows.Forms.GroupBox();
            this.cboNgaySinhHoat = new System.Windows.Forms.ComboBox();
            this.btnThemBuoiSinhHoat = new System.Windows.Forms.Button();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbBuoiSinhHoat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(233, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ĐIỂM DANH";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.chkChonTatCa);
            this.grbDanhSach.Controls.Add(this.btnLuu);
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(13, 92);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(554, 330);
            this.grbDanhSach.TabIndex = 1;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách điểm danh";
            // 
            // chkChonTatCa
            // 
            this.chkChonTatCa.AutoSize = true;
            this.chkChonTatCa.Location = new System.Drawing.Point(9, 307);
            this.chkChonTatCa.Name = "chkChonTatCa";
            this.chkChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chkChonTatCa.TabIndex = 0;
            this.chkChonTatCa.Text = "Chọn tất cả";
            this.chkChonTatCa.UseVisualStyleBackColor = true;
            this.chkChonTatCa.CheckedChanged += new System.EventHandler(this.chkChonTatCa_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(473, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.MSSV,
            this.HoTen});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(542, 276);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSach_CellMouseDown);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(492, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMaBuoi
            // 
            this.lblMaBuoi.AutoSize = true;
            this.lblMaBuoi.Location = new System.Drawing.Point(6, 22);
            this.lblMaBuoi.Name = "lblMaBuoi";
            this.lblMaBuoi.Size = new System.Drawing.Size(91, 13);
            this.lblMaBuoi.TabIndex = 8;
            this.lblMaBuoi.Text = "Mã buổi sinh hoạt";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(398, 19);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.ReadOnly = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(125, 20);
            this.txtDiaDiem.TabIndex = 1;
            this.txtDiaDiem.TabStop = false;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(297, 22);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(95, 13);
            this.lblDiaDiem.TabIndex = 7;
            this.lblDiaDiem.Text = "Địa điểm sinh hoạt";
            // 
            // grbBuoiSinhHoat
            // 
            this.grbBuoiSinhHoat.Controls.Add(this.btnThemBuoiSinhHoat);
            this.grbBuoiSinhHoat.Controls.Add(this.cboNgaySinhHoat);
            this.grbBuoiSinhHoat.Controls.Add(this.lblMaBuoi);
            this.grbBuoiSinhHoat.Controls.Add(this.lblDiaDiem);
            this.grbBuoiSinhHoat.Controls.Add(this.txtDiaDiem);
            this.grbBuoiSinhHoat.Location = new System.Drawing.Point(13, 36);
            this.grbBuoiSinhHoat.Name = "grbBuoiSinhHoat";
            this.grbBuoiSinhHoat.Size = new System.Drawing.Size(554, 50);
            this.grbBuoiSinhHoat.TabIndex = 0;
            this.grbBuoiSinhHoat.TabStop = false;
            this.grbBuoiSinhHoat.Text = "Thông tin buổi sinh hoạt";
            // 
            // cboNgaySinhHoat
            // 
            this.cboNgaySinhHoat.FormattingEnabled = true;
            this.cboNgaySinhHoat.Location = new System.Drawing.Point(112, 19);
            this.cboNgaySinhHoat.Name = "cboNgaySinhHoat";
            this.cboNgaySinhHoat.Size = new System.Drawing.Size(102, 21);
            this.cboNgaySinhHoat.TabIndex = 0;
            this.cboNgaySinhHoat.SelectedIndexChanged += new System.EventHandler(this.cboNgaySinhHoat_SelectedIndexChanged);
            // 
            // btnThemBuoiSinhHoat
            // 
            this.btnThemBuoiSinhHoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBuoiSinhHoat.Location = new System.Drawing.Point(220, 19);
            this.btnThemBuoiSinhHoat.Name = "btnThemBuoiSinhHoat";
            this.btnThemBuoiSinhHoat.Size = new System.Drawing.Size(25, 23);
            this.btnThemBuoiSinhHoat.TabIndex = 1;
            this.btnThemBuoiSinhHoat.Text = "+";
            this.btnThemBuoiSinhHoat.UseVisualStyleBackColor = true;
            this.btnThemBuoiSinhHoat.Click += new System.EventHandler(this.btnThemBuoiSinhHoat_Click);
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // DiemDanhFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 453);
            this.Controls.Add(this.grbBuoiSinhHoat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Name = "DiemDanhFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiemDanhFrm";
            this.Load += new System.EventHandler(this.DiemDanhFrm_Load);
            this.grbDanhSach.ResumeLayout(false);
            this.grbDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbBuoiSinhHoat.ResumeLayout(false);
            this.grbBuoiSinhHoat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaBuoi;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.GroupBox grbBuoiSinhHoat;
        private System.Windows.Forms.ComboBox cboNgaySinhHoat;
        private System.Windows.Forms.CheckBox chkChonTatCa;
        private System.Windows.Forms.Button btnThemBuoiSinhHoat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    }
}