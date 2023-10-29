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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var MaMonHoc = dgvDSMH.Rows[e.RowIndex].Cells["ID_MonHoc"].Value.ToString();
                new frmMonHoc(MaMonHoc).ShowDialog();
                LoadDSMH();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMH();
        }
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                Key = "@TuKhoa",
                Value = txtTuKhoa.Text
            });
            dgvDSMH.DataSource = new Database().SelectData("SelectAllMonHoc", lstPara);
        }
        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["ID_MonHoc"].HeaderText = "Mã môn học";
            dgvDSMH.Columns["Ten_MonHoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["So_TinChi"].HeaderText = "Số tín chỉ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSMH();
        }
    }
}
