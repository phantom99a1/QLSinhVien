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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }
        private void LoadDSGV()
        {
            string sql = "SelectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                Key = "@TuKhoa",
                Value = txtTuKhoa.Text
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGiaoVien(null).ShowDialog();
            LoadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["ID_GiaoVien"].Value.ToString();
                new frmGiaoVien(mgv).ShowDialog();
                LoadDSGV();
            }
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnXoa"].Index)
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên: "+ dgvDSGV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString()+"?","Xác nhận xóa!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maGV = dgvDSGV.Rows[e.RowIndex].Cells["ID_GiaoVien"].Value.ToString();
                        string sql = "XoaGV";
                        var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter()
                        {
                            Key="@ID_GiaoVien",
                            Value=maGV
                        }
                    };

                        var result = new Database().Excute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa giáo viên thành công");
                            LoadDSGV();
                        }
                        else MessageBox.Show("Không thể xóa được giáo viên đã chọn!");
                    }                    
                }
            }
        }
    }
}
