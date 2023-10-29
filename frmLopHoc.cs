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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc(string MaLopHoc)
        {
            this.MaLopHoc = MaLopHoc;
            InitializeComponent();
        }
        private string MaLopHoc;
        private string NguoiThucThi = "admin";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tên môn học!");
                return;
            }
            if (cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên!");
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if(string.IsNullOrEmpty(MaLopHoc)){
                sql = "ThemMoiLopHoc";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiTao",
                    Value=NguoiThucThi
                });
            }
            else
            {
                sql = "CapNhatLopHoc";
                lstPara.Add(new CustomParameter()
                {
                    Key = "@ID_LopHoc",
                    Value = MaLopHoc
                });
                lstPara.Add(new CustomParameter()
                {
                    Key = "@NguoiCapNhat",
                    Value = NguoiThucThi
                });
            }
            lstPara.Add(new CustomParameter()
            {
                Key = "@ID_GiaoVien",
                Value = cbbGiaoVien.SelectedValue.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                Key = "@ID_MonHoc",
                Value = cbbMonHoc.SelectedValue.ToString()
            });

            var result = new Database().Excute(sql, lstPara);
            if (result == 1)
            {
                if (string.IsNullOrEmpty(MaLopHoc))
                    MessageBox.Show("Thêm mới môn học thành công!");
                else
                    MessageBox.Show("Cập nhật thông tin môn học thành công!");
            }
            else MessageBox.Show("Thực thi thất bại!");
            Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key="@TuKhoa",
                    Value=""
                }
            };
            cbbMonHoc.DataSource = new Database().SelectData("SelectAllMonHoc", lstPara);
            cbbMonHoc.DisplayMember = "Ten_MonHoc";
            cbbMonHoc.ValueMember = "ID_MonHoc";
            cbbMonHoc.SelectedIndex = -1;

            cbbGiaoVien.DataSource = new Database().SelectData("SelectAllGV", lstPara);
            cbbGiaoVien.DisplayMember = "HoTen";
            cbbGiaoVien.ValueMember = "ID_GiaoVien";
            cbbGiaoVien.SelectedIndex = -1;
            if (string.IsNullOrEmpty(MaLopHoc))
            {
                Text = "Thêm mới lớp học";
            }
            else{
                Text = "Cập nhật thông tin lớp học";
                var r = new Database().Select("SelectLopHoc '" + MaLopHoc + "'");
                cbbGiaoVien.SelectedValue = r["ID_GiaoVien"].ToString();
                cbbMonHoc.SelectedValue = r["ID_MonHoc"].ToString();
            }
        }
    }
}
