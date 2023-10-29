using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private string NguoiThucThi = "admin";
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
                Text = "Thêm mới sinh viên";
            else
            {
                Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("selectSV '" + msv+ "'");

                txtHo.Text = r["Ho"].ToString();
                txtTenDem.Text = r["TenDem"].ToString();
                txtTen.Text = r["Ten"].ToString();
                mbtNgaySinh.Text = r["Ngay_Sinh"].ToString();
                if (int.Parse(r["GioiTinh"].ToString()) == 0)
                    rbtNam.Checked = true;
                else rbtNu.Checked = true;
                txtQueQuan.Text = r["QueQuan"].ToString();
                txtDiaChi.Text = r["DiaChi"].ToString();
                txtEmail.Text = r["Email"].ToString();
                txtDienThoai.Text = r["DienThoai"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime NgaySinh;
            try
            {
                NgaySinh = DateTime.ParseExact(mbtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mbtNgaySinh.Select();
                return;
            }

            string GioiTinh = rbtNam.Checked ? "0" : "1";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiTao",
                    Value = NguoiThucThi
                });
            }
            else
            {
                sql = "CapNhatSV";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@MaSinhVien",
                    Value = msv
                });
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiCapNhat",
                    Value = NguoiThucThi
                });
            }
            lstPara.Add(new CustomParameter()
            {
                Key = "@Ho",
                Value = txtHo.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@TenDem",
                Value = txtTenDem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@Ten",
                Value = txtTen.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = NgaySinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = GioiTinh
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@QueQuan",
                Value = txtQueQuan.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = txtDiaChi.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@DienThoai",
                Value = txtDienThoai.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@Email",
                Value = txtEmail.Text
            });
            var result = new Database().Excute(sql, lstPara);
            if (result == 1)
            {
                if (string.IsNullOrEmpty(msv))
                    MessageBox.Show("Thêm mới sinh viên thành công");
                else MessageBox.Show("Cập nhật thông tin sinh viên thành công");

                Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
