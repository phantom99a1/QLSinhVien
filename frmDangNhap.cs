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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string TenDangNhap = "";
        public string LoaiTaiKhoan = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!","Tên đăng nhập không được để trống!");
                txtTenDangNhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của tài khoản!!","Mật khẩu không được để trống!!");
                txtMatKhau.Select();
                return;
            }
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    LoaiTaiKhoan = "admin";
                    break;
                case "Giáo viên":
                    LoaiTaiKhoan = "giaovien";
                    break;
                case "Sinh viên":
                    LoaiTaiKhoan = "sinhvien";
                    break;
            }
            TenDangNhap = txtTenDangNhap.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key="@LoaiTaiKhoan",
                    Value=LoaiTaiKhoan
                },
                new CustomParameter()
                {
                    Key="@TenDangNhap",
                    Value=TenDangNhap
                },
                new CustomParameter()
                {
                    Key="@MatKhau",
                    Value=txtMatKhau.Text
                },
            };

            var result = new Database().SelectData("DangNhap", lstPara);
            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc tài khoản", "Tên đăng nhập hoặc tài khoản không hợp lệ!!");
            }
        }
    }
}
