namespace GUI
{
    partial class XemDanhSachHoiVienFrm
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
            this.dtgDanhSachHoiVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachHoiVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDanhSachHoiVien
            // 
            this.dtgDanhSachHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachHoiVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhSachHoiVien.Location = new System.Drawing.Point(0, 0);
            this.dtgDanhSachHoiVien.Name = "dtgDanhSachHoiVien";
            this.dtgDanhSachHoiVien.Size = new System.Drawing.Size(722, 457);
            this.dtgDanhSachHoiVien.TabIndex = 0;
            // 
            // XemDanhSachHoiVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 457);
            this.Controls.Add(this.dtgDanhSachHoiVien);
            this.Name = "XemDanhSachHoiVienFrm";
            this.Text = "XemDanhSachHoiVienFrm";
            this.Load += new System.EventHandler(this.XemDanhSachHoiVienFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachHoiVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachHoiVien;
    }
}