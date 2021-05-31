namespace EDCZONE
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhacc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhangtonkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuphieunhapkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuphieuxuatkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudanhmuc,
            this.mnuhoadon,
            this.mnutimkiem,
            this.mnukho,
            this.mnuthoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunhanvien,
            this.mnukhachhang,
            this.mnunhacc,
            this.mnusanpham});
            this.mnudanhmuc.Image = ((System.Drawing.Image)(resources.GetObject("mnudanhmuc.Image")));
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(133, 29);
            this.mnudanhmuc.Text = "&Danh Mục";
            // 
            // mnunhanvien
            // 
            this.mnunhanvien.Image = ((System.Drawing.Image)(resources.GetObject("mnunhanvien.Image")));
            this.mnunhanvien.Name = "mnunhanvien";
            this.mnunhanvien.Size = new System.Drawing.Size(270, 34);
            this.mnunhanvien.Text = "&Nhân Viên";
            this.mnunhanvien.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // mnukhachhang
            // 
            this.mnukhachhang.Image = ((System.Drawing.Image)(resources.GetObject("mnukhachhang.Image")));
            this.mnukhachhang.Name = "mnukhachhang";
            this.mnukhachhang.Size = new System.Drawing.Size(270, 34);
            this.mnukhachhang.Text = "&Khách Hàng";
            // 
            // mnunhacc
            // 
            this.mnunhacc.Image = ((System.Drawing.Image)(resources.GetObject("mnunhacc.Image")));
            this.mnunhacc.Name = "mnunhacc";
            this.mnunhacc.Size = new System.Drawing.Size(270, 34);
            this.mnunhacc.Text = "&Nhà CC";
            // 
            // mnusanpham
            // 
            this.mnusanpham.Image = ((System.Drawing.Image)(resources.GetObject("mnusanpham.Image")));
            this.mnusanpham.Name = "mnusanpham";
            this.mnusanpham.Size = new System.Drawing.Size(270, 34);
            this.mnusanpham.Text = "&Sản Phẩm";
            // 
            // mnuhoadon
            // 
            this.mnuhoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhoadonban,
            this.mnuhoadonnhap});
            this.mnuhoadon.Image = ((System.Drawing.Image)(resources.GetObject("mnuhoadon.Image")));
            this.mnuhoadon.Name = "mnuhoadon";
            this.mnuhoadon.Size = new System.Drawing.Size(124, 29);
            this.mnuhoadon.Text = "Hóa Đơn";
            // 
            // mnuhoadonban
            // 
            this.mnuhoadonban.Name = "mnuhoadonban";
            this.mnuhoadonban.Size = new System.Drawing.Size(270, 34);
            this.mnuhoadonban.Text = "Hóa Đơn Bán";
            // 
            // mnuhoadonnhap
            // 
            this.mnuhoadonnhap.Name = "mnuhoadonnhap";
            this.mnuhoadonnhap.Size = new System.Drawing.Size(270, 34);
            this.mnuhoadonnhap.Text = "Hóa Đơn Nhập";
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.Image = ((System.Drawing.Image)(resources.GetObject("mnutimkiem.Image")));
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(125, 29);
            this.mnutimkiem.Text = "Tìm Kiếm";
            // 
            // mnukho
            // 
            this.mnukho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhangtonkho,
            this.mnuphieunhapkho,
            this.mnuphieuxuatkho});
            this.mnukho.Image = ((System.Drawing.Image)(resources.GetObject("mnukho.Image")));
            this.mnukho.Name = "mnukho";
            this.mnukho.Size = new System.Drawing.Size(83, 29);
            this.mnukho.Text = "Kho";
            // 
            // mnuhangtonkho
            // 
            this.mnuhangtonkho.Name = "mnuhangtonkho";
            this.mnuhangtonkho.Size = new System.Drawing.Size(270, 34);
            this.mnuhangtonkho.Text = "Hàng Tồn Kho";
            // 
            // mnuphieunhapkho
            // 
            this.mnuphieunhapkho.Name = "mnuphieunhapkho";
            this.mnuphieunhapkho.Size = new System.Drawing.Size(270, 34);
            this.mnuphieunhapkho.Text = "Phiếu Nhập Kho";
            // 
            // mnuphieuxuatkho
            // 
            this.mnuphieuxuatkho.Name = "mnuphieuxuatkho";
            this.mnuphieuxuatkho.Size = new System.Drawing.Size(270, 34);
            this.mnuphieuxuatkho.Text = "Phiếu Xuất Kho";
            // 
            // mnuthoat
            // 
            this.mnuthoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuthoat.Image")));
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(97, 29);
            this.mnuthoat.Text = "Thoát";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EDCZONE.Properties.Resources.z2460538815084_ee782cbcbdd7f1b47f4c5d2ad9d216571;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 413);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EDCZONE.Properties.Resources.z2460532493241_002ebe5564bdc0a9fdfb7450f17be33a;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý xuất nhập kho EDCzone";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnunhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnukhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnunhacc;
        private System.Windows.Forms.ToolStripMenuItem mnusanpham;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonnhap;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnukho;
        private System.Windows.Forms.ToolStripMenuItem mnuhangtonkho;
        private System.Windows.Forms.ToolStripMenuItem mnuphieunhapkho;
        private System.Windows.Forms.ToolStripMenuItem mnuphieuxuatkho;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

