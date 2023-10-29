using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string TenDangNhap = "";
        private string LoaiTaiKhoan = "";
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();
            TenDangNhap = fn.TenDangNhap;
            LoaiTaiKhoan = fn.LoaiTaiKhoan;
            if (LoaiTaiKhoan.Equals("admin"))
            {
                ChamDiemToolStripMenuItem.Visible = false;
                DangKyToolStripMenuItem.Visible = false;
            }
            else
            {
                QuanLyToolStripMenuItem.Visible = false;
                if (fn.LoaiTaiKhoan.Equals("giaovien"))
                {
                    DangKyToolStripMenuItem.Visible = false;

                }
                else
                {
                    ChamDiemToolStripMenuItem.Visible = false;
                }
            }
            frmWelcome f = new frmWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            Text = f.Text;
            pnlContent.Controls.Add(f);
            f.Show();
        }
        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DiemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDiemThi f = new frmDSDiemThi();
            AddForm(f);
        }

        private void GiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddForm(f);
        }

        private void MonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            AddForm(f);
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void LopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLopHoc f = new frmDSLopHoc();
            AddForm(f);
        }

        private void DangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f= new frmDSMHDaDangKy(TenDangNhap);
            AddForm(f);
        }
    }
}
