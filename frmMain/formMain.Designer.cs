namespace frmMain
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệthốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hosonhanvineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuPhầnMềmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệthốngToolStripMenuItem,
            this.DanhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem1,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1732, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệthốngToolStripMenuItem
            // 
            this.hệthốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.dangxuatToolStripMenuItem,
            this.hosonhanvineToolStripMenuItem1,
            this.thoátToolStripMenuItem2});
            this.hệthốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hệthốngToolStripMenuItem.Name = "hệthốngToolStripMenuItem";
            this.hệthốngToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.hệthốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::frmMain.Properties.Resources.login;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + D";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Image = global::frmMain.Properties.Resources.logout;
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(279, 32);
            this.dangxuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // hosonhanvineToolStripMenuItem1
            // 
            this.hosonhanvineToolStripMenuItem1.Image = global::frmMain.Properties.Resources.Administrator_icon;
            this.hosonhanvineToolStripMenuItem1.Name = "hosonhanvineToolStripMenuItem1";
            this.hosonhanvineToolStripMenuItem1.Size = new System.Drawing.Size(279, 32);
            this.hosonhanvineToolStripMenuItem1.Text = "Hồ Sơ Nhân Viên";
            this.hosonhanvineToolStripMenuItem1.Click += new System.EventHandler(this.hosonhanvineToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem2
            // 
            this.thoátToolStripMenuItem2.Image = global::frmMain.Properties.Resources.Actions_edit_delete_icon1;
            this.thoátToolStripMenuItem2.Name = "thoátToolStripMenuItem2";
            this.thoátToolStripMenuItem2.ShortcutKeyDisplayString = "Alt + F4";
            this.thoátToolStripMenuItem2.Size = new System.Drawing.Size(279, 32);
            this.thoátToolStripMenuItem2.Text = "Thoát";
            this.thoátToolStripMenuItem2.Click += new System.EventHandler(this.thoátToolStripMenuItem2_Click);
            // 
            // DanhMụcToolStripMenuItem
            // 
            this.DanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanphamToolStripMenuItem,
            this.NhanVienToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.DanhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem";
            this.DanhMụcToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.DanhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // sanphamToolStripMenuItem
            // 
            this.sanphamToolStripMenuItem.Image = global::frmMain.Properties.Resources.product_icon;
            this.sanphamToolStripMenuItem.Name = "sanphamToolStripMenuItem";
            this.sanphamToolStripMenuItem.ShortcutKeyDisplayString = "Alt + S";
            this.sanphamToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.sanphamToolStripMenuItem.Text = "Sản Phẩm";
            this.sanphamToolStripMenuItem.Click += new System.EventHandler(this.sanphamToolStripMenuItem_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Image = global::frmMain.Properties.Resources.Administrator_icon;
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.ShortcutKeyDisplayString = "Alt + N";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.NhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = global::frmMain.Properties.Resources.customer;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + K";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSảnPhẩmToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            this.thốngKêSảnPhẩmToolStripMenuItem.Image = global::frmMain.Properties.Resources.product_icon;
            this.thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            this.thốngKêSảnPhẩmToolStripMenuItem.ShortcutKeyDisplayString = "Alt + P";
            this.thốngKêSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống Kê Sản Phẩm";
            // 
            // hướngDẫnToolStripMenuItem1
            // 
            this.hướngDẫnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem1,
            this.giớiThiệuPhầnMềmToolStripMenuItem1});
            this.hướngDẫnToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hướngDẫnToolStripMenuItem1.Name = "hướngDẫnToolStripMenuItem1";
            this.hướngDẫnToolStripMenuItem1.Size = new System.Drawing.Size(127, 32);
            this.hướngDẫnToolStripMenuItem1.Text = "Hướng Dẫn";
            // 
            // hướngDẫnSửDụngToolStripMenuItem1
            // 
            this.hướngDẫnSửDụngToolStripMenuItem1.Image = global::frmMain.Properties.Resources.Slide_Show_icon;
            this.hướngDẫnSửDụngToolStripMenuItem1.Name = "hướngDẫnSửDụngToolStripMenuItem1";
            this.hướngDẫnSửDụngToolStripMenuItem1.ShortcutKeyDisplayString = "Alt + H";
            this.hướngDẫnSửDụngToolStripMenuItem1.Size = new System.Drawing.Size(359, 32);
            this.hướngDẫnSửDụngToolStripMenuItem1.Text = "Hướng Dẫn Sử Dụng";
            this.hướngDẫnSửDụngToolStripMenuItem1.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem1_Click);
            // 
            // giớiThiệuPhầnMềmToolStripMenuItem1
            // 
            this.giớiThiệuPhầnMềmToolStripMenuItem1.Image = global::frmMain.Properties.Resources.profile_check_icon;
            this.giớiThiệuPhầnMềmToolStripMenuItem1.Name = "giớiThiệuPhầnMềmToolStripMenuItem1";
            this.giớiThiệuPhầnMềmToolStripMenuItem1.ShortcutKeyDisplayString = "Alt + G";
            this.giớiThiệuPhầnMềmToolStripMenuItem1.Size = new System.Drawing.Size(359, 32);
            this.giớiThiệuPhầnMềmToolStripMenuItem1.Text = "Giới Thiệu Phần Mềm";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(14, 32);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::frmMain.Properties.Resources.BGMAIN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1732, 1055);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1310, 758);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệthốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hosonhanvineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuPhầnMềmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
    }
}

