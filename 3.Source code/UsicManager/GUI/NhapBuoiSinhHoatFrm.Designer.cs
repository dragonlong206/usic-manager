namespace GUI
{
    partial class NhapBuoiSinhHoatFrm
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
            this.lblMaBuoi = new System.Windows.Forms.Label();
            this.txtMaBuoi = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.grbNoiDung = new System.Windows.Forms.GroupBox();
            this.rtfNoiDung = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.grbNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(112, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "NHẬP BUỔI SINH HOẠT";
            // 
            // lblMaBuoi
            // 
            this.lblMaBuoi.AutoSize = true;
            this.lblMaBuoi.Location = new System.Drawing.Point(25, 69);
            this.lblMaBuoi.Name = "lblMaBuoi";
            this.lblMaBuoi.Size = new System.Drawing.Size(45, 13);
            this.lblMaBuoi.TabIndex = 3;
            this.lblMaBuoi.Text = "Mã buổi";
            // 
            // txtMaBuoi
            // 
            this.txtMaBuoi.Location = new System.Drawing.Point(82, 66);
            this.txtMaBuoi.Name = "txtMaBuoi";
            this.txtMaBuoi.ReadOnly = true;
            this.txtMaBuoi.Size = new System.Drawing.Size(114, 20);
            this.txtMaBuoi.TabIndex = 4;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(25, 110);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(51, 13);
            this.lblThoiGian.TabIndex = 3;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/mm/yyyy";
            this.dtpThoiGian.Location = new System.Drawing.Point(82, 106);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(114, 20);
            this.dtpThoiGian.TabIndex = 5;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(25, 145);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(49, 13);
            this.lblDiaDiem.TabIndex = 3;
            this.lblDiaDiem.Text = "Địa điểm";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(82, 142);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(114, 20);
            this.txtDiaDiem.TabIndex = 6;
            // 
            // grbNoiDung
            // 
            this.grbNoiDung.Controls.Add(this.rtfNoiDung);
            this.grbNoiDung.Location = new System.Drawing.Point(228, 46);
            this.grbNoiDung.Name = "grbNoiDung";
            this.grbNoiDung.Size = new System.Drawing.Size(200, 124);
            this.grbNoiDung.TabIndex = 7;
            this.grbNoiDung.TabStop = false;
            this.grbNoiDung.Text = "Nội dung chính";
            // 
            // rtfNoiDung
            // 
            this.rtfNoiDung.Location = new System.Drawing.Point(7, 20);
            this.rtfNoiDung.Name = "rtfNoiDung";
            this.rtfNoiDung.Size = new System.Drawing.Size(187, 96);
            this.rtfNoiDung.TabIndex = 0;
            this.rtfNoiDung.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(356, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(251, 176);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(140, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Location = new System.Drawing.Point(28, 176);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(75, 23);
            this.btnDiemDanh.TabIndex = 11;
            this.btnDiemDanh.Text = "Điểm danh";
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            // 
            // NhapBuoiSinhHoatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 206);
            this.Controls.Add(this.btnDiemDanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbNoiDung);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.txtMaBuoi);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblMaBuoi);
            this.Controls.Add(this.lblTitle);
            this.Name = "NhapBuoiSinhHoatFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapBuoiSinhHoatFrm";
            this.grbNoiDung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaBuoi;
        private System.Windows.Forms.TextBox txtMaBuoi;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.GroupBox grbNoiDung;
        private System.Windows.Forms.RichTextBox rtfNoiDung;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDiemDanh;
    }
}