namespace GUI
{
    partial class DieuChinhCoCauFrm
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
            this.tabCoCauQuanLy = new System.Windows.Forms.TabControl();
            this.tpgDSVaiTro = new System.Windows.Forms.TabPage();
            this.tpgDSLoaiHoiVien = new System.Windows.Forms.TabPage();
            this.tpgChuyenMon = new System.Windows.Forms.TabPage();
            this.tpgDSCapBac = new System.Windows.Forms.TabPage();
            this.tabCoCauQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCoCauQuanLy
            // 
            this.tabCoCauQuanLy.Controls.Add(this.tpgDSVaiTro);
            this.tabCoCauQuanLy.Controls.Add(this.tpgDSLoaiHoiVien);
            this.tabCoCauQuanLy.Controls.Add(this.tpgChuyenMon);
            this.tabCoCauQuanLy.Controls.Add(this.tpgDSCapBac);
            this.tabCoCauQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCoCauQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tabCoCauQuanLy.Name = "tabCoCauQuanLy";
            this.tabCoCauQuanLy.SelectedIndex = 0;
            this.tabCoCauQuanLy.Size = new System.Drawing.Size(496, 431);
            this.tabCoCauQuanLy.TabIndex = 0;
            // 
            // tpgDSVaiTro
            // 
            this.tpgDSVaiTro.Location = new System.Drawing.Point(4, 22);
            this.tpgDSVaiTro.Name = "tpgDSVaiTro";
            this.tpgDSVaiTro.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDSVaiTro.Size = new System.Drawing.Size(488, 405);
            this.tpgDSVaiTro.TabIndex = 0;
            this.tpgDSVaiTro.Text = "DS Vai Trò";
            this.tpgDSVaiTro.UseVisualStyleBackColor = true;
            // 
            // tpgDSLoaiHoiVien
            // 
            this.tpgDSLoaiHoiVien.Location = new System.Drawing.Point(4, 22);
            this.tpgDSLoaiHoiVien.Name = "tpgDSLoaiHoiVien";
            this.tpgDSLoaiHoiVien.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDSLoaiHoiVien.Size = new System.Drawing.Size(488, 405);
            this.tpgDSLoaiHoiVien.TabIndex = 1;
            this.tpgDSLoaiHoiVien.Text = "DS Loại Hội Viên";
            this.tpgDSLoaiHoiVien.UseVisualStyleBackColor = true;
            // 
            // tpgChuyenMon
            // 
            this.tpgChuyenMon.Location = new System.Drawing.Point(4, 22);
            this.tpgChuyenMon.Name = "tpgChuyenMon";
            this.tpgChuyenMon.Padding = new System.Windows.Forms.Padding(3);
            this.tpgChuyenMon.Size = new System.Drawing.Size(488, 405);
            this.tpgChuyenMon.TabIndex = 2;
            this.tpgChuyenMon.Text = "DS Chuyên Môn";
            this.tpgChuyenMon.UseVisualStyleBackColor = true;
            // 
            // tpgDSCapBac
            // 
            this.tpgDSCapBac.Location = new System.Drawing.Point(4, 22);
            this.tpgDSCapBac.Name = "tpgDSCapBac";
            this.tpgDSCapBac.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDSCapBac.Size = new System.Drawing.Size(488, 405);
            this.tpgDSCapBac.TabIndex = 3;
            this.tpgDSCapBac.Text = "DS Cấp Bậc";
            this.tpgDSCapBac.UseVisualStyleBackColor = true;
            // 
            // DieuChinhCoCauFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 431);
            this.Controls.Add(this.tabCoCauQuanLy);
            this.Name = "DieuChinhCoCauFrm";
            this.Text = "DieuChinhCoCauFrm";
            this.tabCoCauQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCoCauQuanLy;
        private System.Windows.Forms.TabPage tpgDSVaiTro;
        private System.Windows.Forms.TabPage tpgDSLoaiHoiVien;
        private System.Windows.Forms.TabPage tpgChuyenMon;
        private System.Windows.Forms.TabPage tpgDSCapBac;
    }
}