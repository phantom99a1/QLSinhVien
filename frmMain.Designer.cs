
namespace QLSinhVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiemThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ChamDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.QuanLyToolStripMenuItem,
            this.DangKyToolStripMenuItem,
            this.ChamDiemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoiMatKhauToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // DoiMatKhauToolStripMenuItem
            // 
            this.DoiMatKhauToolStripMenuItem.Name = "DoiMatKhauToolStripMenuItem";
            this.DoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.DoiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiemThiToolStripMenuItem,
            this.GiaoVienToolStripMenuItem,
            this.MonHocToolStripMenuItem,
            this.SinhVienToolStripMenuItem,
            this.LopHocToolStripMenuItem});
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.QuanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // DiemThiToolStripMenuItem
            // 
            this.DiemThiToolStripMenuItem.Name = "DiemThiToolStripMenuItem";
            this.DiemThiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DiemThiToolStripMenuItem.Text = "Điểm thi";
            this.DiemThiToolStripMenuItem.Click += new System.EventHandler(this.DiemThiToolStripMenuItem_Click);
            // 
            // GiaoVienToolStripMenuItem
            // 
            this.GiaoVienToolStripMenuItem.Name = "GiaoVienToolStripMenuItem";
            this.GiaoVienToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.GiaoVienToolStripMenuItem.Text = "Giáo viên";
            this.GiaoVienToolStripMenuItem.Click += new System.EventHandler(this.GiaoVienToolStripMenuItem_Click);
            // 
            // MonHocToolStripMenuItem
            // 
            this.MonHocToolStripMenuItem.Name = "MonHocToolStripMenuItem";
            this.MonHocToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MonHocToolStripMenuItem.Text = "Môn học";
            this.MonHocToolStripMenuItem.Click += new System.EventHandler(this.MonHocToolStripMenuItem_Click);
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.SinhVienToolStripMenuItem.Text = "Sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // LopHocToolStripMenuItem
            // 
            this.LopHocToolStripMenuItem.Name = "LopHocToolStripMenuItem";
            this.LopHocToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.LopHocToolStripMenuItem.Text = "Lớp học";
            this.LopHocToolStripMenuItem.Click += new System.EventHandler(this.LopHocToolStripMenuItem_Click);
            // 
            // DangKyToolStripMenuItem
            // 
            this.DangKyToolStripMenuItem.Name = "DangKyToolStripMenuItem";
            this.DangKyToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.DangKyToolStripMenuItem.Text = "Đăng ký môn học";
            this.DangKyToolStripMenuItem.Click += new System.EventHandler(this.DangKyToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 33);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1041, 513);
            this.pnlContent.TabIndex = 1;
            // 
            // ChamDiemToolStripMenuItem
            // 
            this.ChamDiemToolStripMenuItem.Name = "ChamDiemToolStripMenuItem";
            this.ChamDiemToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.ChamDiemToolStripMenuItem.Text = "Chấm Điểm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 546);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiemThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GiaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangKyToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem LopHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChamDiemToolStripMenuItem;
    }
}

