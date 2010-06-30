namespace GUI
{
    partial class NhapChuyenMonFrm
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
            this.lblTraCuuDDTQ = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMaChuyenMon = new System.Windows.Forms.Label();
            this.txtMaChuyenMon = new System.Windows.Forms.TextBox();
            this.txtTenChuyenMon = new System.Windows.Forms.TextBox();
            this.lblTenChuyenMon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTraCuuDDTQ
            // 
            this.lblTraCuuDDTQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTraCuuDDTQ.AutoSize = true;
            this.lblTraCuuDDTQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraCuuDDTQ.ForeColor = System.Drawing.Color.Blue;
            this.lblTraCuuDDTQ.Location = new System.Drawing.Point(37, 9);
            this.lblTraCuuDDTQ.Name = "lblTraCuuDDTQ";
            this.lblTraCuuDDTQ.Size = new System.Drawing.Size(212, 24);
            this.lblTraCuuDDTQ.TabIndex = 4;
            this.lblTraCuuDDTQ.Text = "NHẬP CHUYÊN MÔN";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMaChuyenMon
            // 
            this.lblMaChuyenMon.AutoSize = true;
            this.lblMaChuyenMon.Location = new System.Drawing.Point(12, 51);
            this.lblMaChuyenMon.Name = "lblMaChuyenMon";
            this.lblMaChuyenMon.Size = new System.Drawing.Size(83, 13);
            this.lblMaChuyenMon.TabIndex = 31;
            this.lblMaChuyenMon.Text = "Mã chuyên môn";
            // 
            // txtMaChuyenMon
            // 
            this.txtMaChuyenMon.Location = new System.Drawing.Point(153, 48);
            this.txtMaChuyenMon.Name = "txtMaChuyenMon";
            this.txtMaChuyenMon.ReadOnly = true;
            this.txtMaChuyenMon.Size = new System.Drawing.Size(128, 20);
            this.txtMaChuyenMon.TabIndex = 32;
            // 
            // txtTenChuyenMon
            // 
            this.txtTenChuyenMon.Location = new System.Drawing.Point(153, 102);
            this.txtTenChuyenMon.Name = "txtTenChuyenMon";
            this.txtTenChuyenMon.Size = new System.Drawing.Size(128, 20);
            this.txtTenChuyenMon.TabIndex = 33;
            // 
            // lblTenChuyenMon
            // 
            this.lblTenChuyenMon.AutoSize = true;
            this.lblTenChuyenMon.Location = new System.Drawing.Point(12, 105);
            this.lblTenChuyenMon.Name = "lblTenChuyenMon";
            this.lblTenChuyenMon.Size = new System.Drawing.Size(87, 13);
            this.lblTenChuyenMon.TabIndex = 31;
            this.lblTenChuyenMon.Text = "Tên chuyên môn";
            // 
            // NhapChuyenMonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 210);
            this.Controls.Add(this.txtTenChuyenMon);
            this.Controls.Add(this.txtMaChuyenMon);
            this.Controls.Add(this.lblTenChuyenMon);
            this.Controls.Add(this.lblMaChuyenMon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTraCuuDDTQ);
            this.Name = "NhapChuyenMonFrm";
            this.Text = "NhapChuyenMonFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraCuuDDTQ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaChuyenMon;
        private System.Windows.Forms.TextBox txtMaChuyenMon;
        private System.Windows.Forms.TextBox txtTenChuyenMon;
        private System.Windows.Forms.Label lblTenChuyenMon;
    }
}