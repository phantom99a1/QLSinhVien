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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void DSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                Key = "@TuKhoa",
                Value = txtTuKhoa.Text
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien",lstPara);

            dgvSinhVien.Columns["ID_SinhVien"].HeaderText = "ID";
            dgvSinhVien.Columns["Ma_SinhVien"].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvSinhVien.Columns["Ngay_Sinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["Gioi_Tinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["QueQuan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["Email"].HeaderText = "Email";
        }
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["Ma_SinhVien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }
    }
}
