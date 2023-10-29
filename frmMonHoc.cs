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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc(string MaMonHoc)
        {
            this.MaMonHoc = MaMonHoc;
            InitializeComponent();
        }
        private string MaMonHoc;
        private string NguoiThucThi = "admin";
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaMonHoc))
            {
                Text = "Thêm mới môn học";
            }
            else
            {
                Text = "Cập nhật thông tin môn học";
                var r=new Database().Select("SelectMonHoc '" + MaMonHoc + "'");
                txtTenMonHoc.Text = r["Ten_MonHoc"].ToString();
                txtSoTinChi.Text = r["So_TinChi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txtSoTinChi.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải là số dương");
                    txtSoTinChi.Select();
                    return;
                }                    
            }
            catch
            {
                MessageBox.Show("Số tín chỉ phải là số nguyên");
                txtSoTinChi.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("tên môn học không được để trống!");
                txtTenMonHoc.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(MaMonHoc))
            {
                sql = "ThemMoiMonHoc";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiTao",
                    Value = NguoiThucThi
                });
            }
            else
            {
                sql = "CapNhatMonHoc";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@ID_MonHoc",
                    Value = MaMonHoc
                });
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiCapNhat",
                    Value = NguoiThucThi
                });
            }
            lstPara.Add(new CustomParameter()
            {
                Key = "@Ten_MonHoc",
                Value = txtTenMonHoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@So_TinChi",
                Value = txtSoTinChi.Text
            });

            var result = new Database().Excute(sql, lstPara);
            if (result == 1)
            {
                if (string.IsNullOrEmpty(MaMonHoc))
                    MessageBox.Show("Thêm mới môn học thành công!");
                else MessageBox.Show("Cập nhật môn học thành công!!");
                Dispose();
            }
            else MessageBox.Show("Thực thi thất bại!!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
