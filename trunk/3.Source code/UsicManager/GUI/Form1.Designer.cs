namespace GUI
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.quảnLýHộiViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHộiViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhHoạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBuổiSinhHoạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHộiViênToolStripMenuItem,
            this.quảnLýSinhHoạtToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(680, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // quảnLýHộiViênToolStripMenuItem
            // 
            this.quảnLýHộiViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHộiViênToolStripMenuItem});
            this.quảnLýHộiViênToolStripMenuItem.Name = "quảnLýHộiViênToolStripMenuItem";
            this.quảnLýHộiViênToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.quảnLýHộiViênToolStripMenuItem.Text = "Quản lý hội viên";
            // 
            // thêmHộiViênToolStripMenuItem
            // 
            this.thêmHộiViênToolStripMenuItem.Name = "thêmHộiViênToolStripMenuItem";
            this.thêmHộiViênToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.thêmHộiViênToolStripMenuItem.Text = "&Thêm hội viên";
            this.thêmHộiViênToolStripMenuItem.Click += new System.EventHandler(this.thêmHộiViênToolStripMenuItem_Click);
            // 
            // quảnLýSinhHoạtToolStripMenuItem
            // 
            this.quảnLýSinhHoạtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBuổiSinhHoạtToolStripMenuItem});
            this.quảnLýSinhHoạtToolStripMenuItem.Name = "quảnLýSinhHoạtToolStripMenuItem";
            this.quảnLýSinhHoạtToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.quảnLýSinhHoạtToolStripMenuItem.Text = "Quản lý sinh hoạt";
            // 
            // thêmBuổiSinhHoạtToolStripMenuItem
            // 
            this.thêmBuổiSinhHoạtToolStripMenuItem.Name = "thêmBuổiSinhHoạtToolStripMenuItem";
            this.thêmBuổiSinhHoạtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thêmBuổiSinhHoạtToolStripMenuItem.Text = "&Thêm buổi sinh hoạt";
            this.thêmBuổiSinhHoạtToolStripMenuItem.Click += new System.EventHandler(this.thêmBuổiSinhHoạtToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.blue_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 462);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsicManager";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHộiViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHộiViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhHoạtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBuổiSinhHoạtToolStripMenuItem;
    }
}

